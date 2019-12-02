using EllieMae.Encompass.BusinessObjects.Loans;

namespace CommunityPlugin.Objects.Interface
{
    public interface ILogEntryRemoved
    {
        void LogEntryRemoved(object sender, LogEntryEventArgs e);
    }
}
