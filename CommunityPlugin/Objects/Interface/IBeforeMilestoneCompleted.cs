using EllieMae.Encompass.BusinessObjects.Loans;

namespace CommunityPlugin.Objects.Interface
{
    public interface IBeforeMilestoneCompleted
    {
        void BeforeMilestoneCompleted(object sender, CancelableMilestoneEventArgs e);
    }
}
