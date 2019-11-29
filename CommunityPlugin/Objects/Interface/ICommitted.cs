using EllieMae.Encompass.BusinessObjects;

namespace CommunityPlugin.Objects.Interface
{
    public interface ICommitted
    {
        void Committed(object sender, PersistentObjectEventHandler e);
    }
}
