using EllieMae.Encompass.BusinessObjects.Loans;

namespace CommunityPlugin.Objects.Interface
{
    public interface ILogEntryAdded
    {
        void LogEntryAdded(object sender, LogEntryEventArgs e);
    }
}
