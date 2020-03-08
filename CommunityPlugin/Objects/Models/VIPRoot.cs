using Newtonsoft.Json;
using System.Collections.Generic;

namespace CommunityPlugin.Objects.Models
{
    public class VIPRoot
    {
        [JsonProperty("Loans")]
        public List<string> Loans { get; set; }
        
        public VIPRoot()
        {
            Loans = new List<string>();
        }
    }
}
