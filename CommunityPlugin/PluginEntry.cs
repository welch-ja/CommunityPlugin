using CommunityPlugin.Objects;
using EllieMae.Encompass.ComponentModel;

namespace CommunityPlugin
{
    [Plugin]
    public class PluginEntry
    {
        public PluginEntry()
        {
            Plugins.Start();
        }
    }
}
