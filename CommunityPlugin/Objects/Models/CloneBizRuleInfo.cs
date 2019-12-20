using CommunityPlugin.Objects.Enums;

namespace CommunityPlugin.Objects.Models
{
    public class CloneBizRuleInfo
    {
        public string AdvancedCodeXML { get; set; }

        public string CommentsTxt { get; set; }
        public string Condition2 { get; set; }
        public string ConditionState { get; set; }
        public string ConditionState2 { get; set; }
        public int ConditionStateInt { get; set; }
        public bool Inactive { get; set; }
        public bool IsGeneralRule { get; set; }
        public string LastModifiedByFullName { get; set; }
        public string LastModifiedByUserId { get; set; }
        public string LastModifiedByUserInfo { get; set; }
        public string MilestoneID { get; set; }
        public int RoleID { get; set; }
        public int RuleID { get; set; }
        public string RuleName { get; set; }
        public int RuleType { get; set; }
        public bool Active { get; set; } 
        public int Condition { get; set; }
    }
}
