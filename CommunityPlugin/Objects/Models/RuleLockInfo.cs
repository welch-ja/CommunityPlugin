using EllieMae.EMLite.ClientServer;

namespace CommunityPlugin.Objects.Models
{
    public class RuleLockInfo
    {
        public string ID { get; set; }
        public int RuleID { get; set; }
        public string RuleName { get; set; }
        public bool Locked { get; set; }

        public CloneBizRuleInfo Original { get; set; }

        public RuleLockInfo()
        {

        }

        public RuleLockInfo(BizRuleInfo Info)
        {
            Original = new CloneBizRuleInfo();
            Original.AdvancedCodeXML = Info.AdvancedCodeXML;
            Original.CommentsTxt = Info.CommentsTxt;
            Original.Condition =  (int)Info.Condition;
            Original.Condition2 = Info.Condition2;
            Original.ConditionState = Info.ConditionState;
            Original.ConditionState2 = Info.ConditionState2;
            Original.ConditionStateInt = Info.ConditionStateInt;
            Original.Inactive = Info.Inactive;
            Original.IsGeneralRule = Info.IsGeneralRule;
            Original.LastModifiedByFullName = Info.LastModifiedByFullName;
            Original.LastModifiedByUserId = Info.LastModifiedByUserId;
            Original.LastModifiedByUserInfo = Info.LastModifiedByUserInfo;
            Original.MilestoneID = Info.MilestoneID;
            Original.RoleID = Info.RoleID;
            Original.RuleID = Info.RuleID;
            Original.RuleName = Info.RuleName;
            Original.RuleType = (int)Info.RuleType;
            Original.Active = Info.Status == BizRule.RuleStatus.Active; 
        }
    }
}
