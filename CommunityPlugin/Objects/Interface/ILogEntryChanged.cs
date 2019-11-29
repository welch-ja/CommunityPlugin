using EllieMae.Encompass.BusinessObjects.Loans;

namespace CommunityPlugin.Objects.Interface
{
    public interface ILogEntryChanged
    {
        void LogEntryChanged(object sender, LogEntryEventArgs e);
    }
}
