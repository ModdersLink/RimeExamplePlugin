using System.Windows.Forms;
using RimeCommon.Plugins;
using RimeCommon.Messaging;
using RimeCommon.Content.Messages;
using RimeCommon.Logging;

namespace RimePluginExample
{
    public class RimeExamplePlugin : RimePlugin
    {
        public override string Name => "Rime Example Plugin";
        public override string Author => "Example Author";
        public override string Version => "1.0";
        public override string Description => "An description for the example plugin, hmmm.... what should it be?";
        public override string Extension => "_rime-plugin-example";
        public override UserControl MainControl => null;
        public override MountPoint Mount => MountPoint.None;

        public override void Init(params object[] p_Params)
        {
            m_MessageListener.RegisterListener(MessagingSubSystem.Content);

            m_MessageListener.RegisterMessageCallback(typeof(ContentRequestOpenMessage), OnContentRequestOpen);

            WriteLog(LogsLevel.All, "RimeExamplePlugin Init called.");
        }

        private void OnContentRequestOpen(RimeMessage p_Message)
        {
            var s_Message = (ContentRequestOpenMessage)p_Message;

            WriteLog(LogsLevel.All, "Swag, Swag, Swag, Swag");
        }
    }
}
