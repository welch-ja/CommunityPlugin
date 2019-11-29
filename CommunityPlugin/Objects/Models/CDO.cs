using Newtonsoft.Json;

namespace CommunityPlugin.Objects.Models
{
    public class CDO
    {
        [JsonProperty("CommunitySettings")]
        public SettingsCDO CommunitySettings { get; set; }
    }
}
