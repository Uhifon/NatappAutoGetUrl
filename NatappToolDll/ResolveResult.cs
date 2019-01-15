namespace NatappToolDll
{
    public class ResolveResult
    {
        /// <summary>
        /// 服务器域名 
        /// </summary>
        public string serverUrl { get; set; }
        /// <summary>
        /// 服务器端口
        /// </summary>
        public int? serverPort { get; set; }
        /// <summary>
        /// 本地地址
        /// </summary>
        public string localIP { get; set; }
        /// <summary>
        /// 本地端口
        /// </summary>
        public int localPort { get; set; }
    }
}
