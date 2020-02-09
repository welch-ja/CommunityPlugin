using EllieMae.EMLite.ClientServer.Reporting;

namespace CommunityPlugin.Objects.Models
{
    public class PipelineFilter
    {
        public string Name { get; set; }

        public bool Public { get; set; }

        public string Owner { get; set; }

        public string Folder { get; set; }

        public string PipelineView { get; set; }

        public FieldFilterList Filter { get; set; }
    }
}