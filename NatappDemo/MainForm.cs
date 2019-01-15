using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NatappToolDll;

namespace NatappDemo
{
    public partial class MainForm : Form
    {
        NatappToolDll.NatappResolve natappResolve;
        public MainForm()
        {
            InitializeComponent();
            natappResolve = new NatappToolDll.NatappResolve();
        }

        private void btnNatappAddress_Click(object sender, EventArgs e)
        {
            tbNatappAddress.Text = SelectedPath();
        }


        /// <summary>
        /// 选择目录
        /// </summary>
        /// <returns></returns>
        private string SelectedPath()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择所有文件存放目录";

            if (folder.ShowDialog() == DialogResult.OK)
            {

                return folder.SelectedPath;

            }
            else
                return null;
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            natappResolve.CloseNatappServer();
            Environment.Exit(0);
 
        }

        private void btnStartWeb_Click(object sender, EventArgs e)
        {
            string _natappPath = tbNatappAddress.Text;
            string _authtoken = tbAuthtokenWeb.Text;
            tbProtocol.Text = "WEB";
            StartResolve(_natappPath, NatappToolDll.TunnelingProtocol.WEB,_authtoken);
        }


        private void btnStartTCP_Click(object sender, EventArgs e)
        {
            string _natappPath = tbNatappAddress.Text;
            string _authtoken = tbAuthtokenTCP.Text;
            tbProtocol.Text = "TCP";
            StartResolve(_natappPath, NatappToolDll.TunnelingProtocol.TCP,_authtoken);
        }

        private void btnStartUDP_Click(object sender, EventArgs e)
        {
            string _natappPath = tbNatappAddress.Text;
            string _authtoken = tbAuthtokenUDP.Text;
            tbProtocol.Text = "UDP";
            StartResolve(_natappPath, NatappToolDll.TunnelingProtocol.UDP,_authtoken);
        }


        /// <summary>
        /// 开始解析
        /// </summary>
        /// <param name="natappPath"></param>
        /// <param name="authtoken"></param>
        public void StartResolve(string natappPath, NatappToolDll.TunnelingProtocol tunnelingProtocol, string authtoken)
        {
            NatappToolDll.ResolveResult rr = new NatappToolDll.ResolveResult();
            bool res = natappResolve.StartResolve(natappPath, authtoken, tunnelingProtocol, out rr);

            tbServerUrl.Text = rr.serverUrl;
            tbServerPort.Text = rr.serverPort.ToString();
            tbLocalIP.Text = rr.localIP;
            tbLocalPort.Text = rr.localPort.ToString();
        }

     

       

    }
}
