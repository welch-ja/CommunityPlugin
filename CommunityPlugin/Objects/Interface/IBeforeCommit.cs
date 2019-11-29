using EllieMae.Encompass.BusinessObjects.Loans;

namespace CommunityPlugin.Objects.Interface
{
    public interface IBeforeCommit
    {
        void BeforeCommit(object sender, CancelableEventArgs e);
    }
}
