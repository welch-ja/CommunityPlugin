using CommunityPlugin.Objects.Helpers;
using EllieMae.Encompass.Client;
using System;

namespace CommunityPlugin.Objects
{
    public static class Logger
    {
        public static void HandleError(Exception Ex, string Name, object data = null)
        {
            try
            {
                if (string.IsNullOrEmpty(Name))
                    return;

                ApplicationLog.WriteError(nameof(CommunityPlugin), $"{Name}{Environment.NewLine}{Ex.ToString()}");
            }
            catch(Exception ex)
            {
                Logger.Fatal(ex.ToString());
            }
        }

        private static void Fatal(string Text, object data = null)
        {
            ApplicationLog.WriteError(EncompassHelper.LoanNumber(), "Fatal");
        }
    }
}
