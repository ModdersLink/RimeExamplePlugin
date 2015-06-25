using System.Windows.Controls;
using RimeCommon.Logging;
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
        public override MountPoint Mount { get { return MountPoint.Center; } }

        public RimeExamplePlugin()
        {
            WriteLog(LogsLevel.All, "RimeExamplePlugin ctor called.");
        }

        public override void Init()
        {
            
        }
    }
}
