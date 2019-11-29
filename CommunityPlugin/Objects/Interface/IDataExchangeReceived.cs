using EllieMae.Encompass.Client;
using System;

namespace CommunityPlugin.Objects.Interface
{
    public interface IDataExchangeReceived
    {
        void DataExchangeReceived(object sender, DataExchangeEventArgs e);
    }
}
