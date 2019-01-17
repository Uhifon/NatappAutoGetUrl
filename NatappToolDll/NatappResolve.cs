using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace NatappToolDll
{
    /// <summary>
    /// 通道协议
    /// </summary>
    public enum TunnelingProtocol
    {
        WEB = 0,
        TCP = 1,
        UDP = 2

    }
     
    public class NatappResolve
    {
        Process process;
        static string logPath = "log.txt";

        /// <summary>
        /// 开始解析
        /// </summary>
        /// <param name="natappDir">natapp.exe目录</param>
        /// <param name="authtoken">authtoken码</param>
        /// <param name="domainNameAndPort">域名和端口号</param>
        /// <returns></returns>
        public bool StartResolve(string natappDir, string authtoken, TunnelingProtocol tunnelingProtocol, out ResolveResult resolveResult)
        {
            resolveResult = new ResolveResult();
            try
            {
                //【1】创建配置文件
                string natappFilePath = natappDir + "\\natapp.exe";
                if (File.Exists(natappFilePath) && authtoken != "")
                {
                    CreatConfigureFile(natappDir, authtoken);
                }
                else
                    return false;
               //【2】打开natapp.exe            
                StartNatapp(natappFilePath);
                Thread.Sleep(1000);

                //【3】分析日志
                using (FileStream fs = new FileStream(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
                {
                    StringBuilder sb = new StringBuilder();              
                    while (!sr.EndOfStream)
                    {
                        sb.AppendLine(sr.ReadLine() + "<br>");
                    }
                    string str = sb.ToString();
                    int x = str.IndexOf("Url");  //定位位置
                    string validData = str.Substring(x, 100);
                    string[] strTmps = validData.Split('"');
                    string[] serverStr = strTmps[2].Split(':');
                    resolveResult.serverUrl = serverStr[0] + ":" + serverStr[1];
                    if (tunnelingProtocol == TunnelingProtocol.TCP || tunnelingProtocol == TunnelingProtocol.UDP)
                        resolveResult.serverPort = int.Parse(serverStr[2]);
                    resolveResult.localIP = strTmps[10].Split(':')[0];
                    resolveResult.localPort = int.Parse(strTmps[10].Split(':')[1]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// 删除日志文件
        /// </summary>
        /// <param name="directoryPath"> 文件夹路径 </param>
        /// <param name="fileName"> 文件名称 </param>
        private static void DeleteFolder()
        {
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo fi in fis)
            {
                try
                {
                    if (fi.Name.Contains(logPath))
                    {
                        fi.Delete();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        /// <summary>
        /// 创建natapp的配置文件config.ini
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="authtoken"></param>
        /// <param name="clienttoken"></param>
        /// <param name="logFilePath"></param>
        /// <param name="loglevel"></param>
        /// <param name="httpProxy"></param>
        private void CreatConfigureFile(string dirPath, string authtoken, string clienttoken = null)
        {
            string filePath = dirPath + "\\config.ini";
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("[default]");
                sb.AppendLine("authtoken=" + authtoken);//对应一条隧道的authtoken
                sb.AppendLine("clienttoken=" + clienttoken);//对应客户端的clienttoken,将会忽略authtoken,若无请留空
                sb.AppendLine("log=" +logPath);//log 日志文件,可指定本地文件, none=不做记录,stdout=直接屏幕输出 ,默认为none
                sb.AppendLine("loglevel=DEBUG");//日志等级 DEBUG, INFO, WARNING, ERROR 默认为 DEBUG
                sb.AppendLine("http_proxy=");//代理设置 如 http://10.123.10.10:3128 非代理上网用户请务必留空

                string str = sb.ToString(); ;
                byte[] data = System.Text.Encoding.Default.GetBytes(str);
                //开始写入
                fs.Write(data, 0, data.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
            }
            catch(Exception ex)
            { 
            }

        }

        /// <summary>
        /// 打开natapp.exe 并嵌套到本程序窗体内
        /// </summary>
        private void StartNatapp(string appPath)
        {
            KillProcess("natapp");
            DeleteFolder();
            process = null;
            process = new Process();
            process.StartInfo.FileName = appPath;            // 需要启动的程序
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;    // 为了美观,启动的时候最小化程序
            process.Start();
            Thread.Sleep(1000);  // 这里必须等待,否则启动程序的句柄还没有创建,不能控制程序
        }

        /// <summary>
        /// 关闭进程
        /// </summary>
        /// <param name="processName">进程名</param>
        private void KillProcess(string processName)
        {
            Process[] myproc = Process.GetProcesses();
            foreach (Process item in myproc)
            {
                if (item.ProcessName == processName)
                {
                    item.Kill();
                }
            }
        }

        /// <summary>
        /// 关闭natapp服务
        /// </summary>
        public void CloseNatappServer()
        {
            KillProcess("natapp");
        }

    }
}
