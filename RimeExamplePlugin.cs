using System.Windows.Controls;

using RimeCommon.Plugins;
using RimeCommon.Messaging;
using RimeCommon.Messages;
using RimeCommon.Content.Messages;
using RimeCommon.Logging;

namespace RimePluginExample
{
    public class RimeExamplePlugin : RimePlugin
    {
        public override string Name { get { return "Rime Example Plugin"; } }
        public override string Author { get { return "Example Author"; } }
        public override string Version { get { return "1.0"; } }
        public override string Description { get { return "An description for the example plugin, hmmm.... what should it be?"; } }
        public override string Extension { get { return "_rime-plugin-example"; } }
        public override UserControl MainControl { get { return null; } }
        public override MountPoint Mount { get { return MountPoint.None; } }

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
