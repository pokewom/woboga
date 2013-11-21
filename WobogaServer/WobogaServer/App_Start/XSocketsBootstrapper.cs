using System.Web;
using XSockets.Core.Common.Socket;

[assembly: PreApplicationStartMethod(typeof(WobogaServer.App_Start.XSocketsBootstrap), "Start")]

namespace WobogaServer.App_Start
{
    public static class XSocketsBootstrap
    {
        private static IXSocketServerContainer wss;
        public static void Start()
        {
            wss = XSockets.Plugin.Framework.Composable.GetExport<IXSocketServerContainer>();
            wss.StartServers();
        }        
    }
}