using CommunityPlugin.Objects.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CommunityPlugin.Objects.Helpers
{
    public class PipelineFilterCDORoot
    {
        [JsonProperty("Filters")]
        public List<PipelineFilter> Filters { get; set; }

        public PipelineFilterCDORoot()
        {
            Filters = new List<PipelineFilter>();
        }
    }
}
