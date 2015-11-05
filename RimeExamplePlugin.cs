using System.Windows.Controls;
using RimeCommon.Content.Messages;
using RimeCommon.Logging;
using RimeCommon.Messaging;
using RimeCommon.Plugins;

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
            RegisterListener(MessagingSubSystem.Content);

            RegisterMessageCallback(typeof(ContentRequestOpen), OnContentRequestOpen);

            WriteLog(LogsLevel.All, "RimeExamplePlugin Init called.");
        }

        private void OnContentRequestOpen(RimeMessage p_Message)
        {
            var s_Message = (ContentRequestOpen) p_Message;

            WriteLog(LogsLevel.All, "Swag, Swag, Swag, Swag");
        }
    }
}
