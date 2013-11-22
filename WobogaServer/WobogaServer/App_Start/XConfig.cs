using XSockets.Core.Configuration;

namespace WobogaServer.App_Start
{ 
    /// <summary>
    /// Each ConfigurationSetting class will provide a new server
    /// </summary>
    public class XConfig : ConfigurationSetting
    {
        public XConfig():base("ws://wobogasi.apphb.com:80"){}
    }
}