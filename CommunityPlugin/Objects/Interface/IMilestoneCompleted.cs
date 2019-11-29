using EllieMae.Encompass.BusinessObjects.Loans;

namespace CommunityPlugin.Objects.Interface
{
    public interface IMilestoneCompleted
    {
        void MilestoneCompleted(object sender, MilestoneEventArgs e);
    }
}
