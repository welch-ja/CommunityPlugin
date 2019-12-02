using EllieMae.Encompass.BusinessObjects.Loans;
using System;

namespace CommunityPlugin.Objects.Args
{
    public class BorrowerPairChangedEventArgs: EventArgs
    {
        public BorrowerPair CurrentPair { get; }

        public BorrowerPairChangedEventArgs(BorrowerPair e)
        {
            CurrentPair = e;
        }
    }
}
