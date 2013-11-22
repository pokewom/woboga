using XSockets.Core.Configuration;

namespace WobogaServer.App_Start
{ 
    /// <summary>
    /// Each ConfigurationSetting class will provide a new server
    /// </summary>
    public class XConfig : ConfigurationSetting
    {
        public XConfig():base("ws://woboga.apphb.com:80"){}
    }
}