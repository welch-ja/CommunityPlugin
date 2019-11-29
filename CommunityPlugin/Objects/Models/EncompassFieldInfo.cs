using CommunityPlugin.Objects.Helpers;

namespace CommunityPlugin.Objects.Models
{
    public class EncompassFieldInfo
    {
        public string Description { get; set; }
        public string Value { get; set; }

        public EncompassFieldInfo(string FieldID, string Description)
        {
            this.Description = !string.IsNullOrEmpty(Description) ? $"{Description}" : $"{EncompassHelper.FieldDescription(FieldID).Replace("Trans Details ", "")} [{FieldID}]";
            this.Value = EncompassHelper.Val(FieldID);
        }
    }
}
