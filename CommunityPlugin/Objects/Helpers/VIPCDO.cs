using CommunityPlugin.Objects.Models;
using EllieMae.Encompass.Automation;
using Newtonsoft.Json;
using System;
using System.Text;

namespace CommunityPlugin.Objects.Helpers
{
    public class VIPCDO
    {
        private static VIPRoot AdminCDOFile;

        public static VIPRoot CDO
        {
            get
            {
                if (AdminCDOFile == null)
                    DownloadCDO();

                return AdminCDOFile;
            }
        }

        private static void DownloadCDO()
        {
            try
            {
                AdminCDOFile = JsonConvert.DeserializeObject<VIPRoot>(Encoding.UTF8.GetString(EncompassApplication.Session.DataExchange.GetCustomDataObject("VIPCDO.json").Data));
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(VIPRoot));
                UpdateCDO(new VIPRoot());
                UploadCDO();
            }
        }

        public static void UpdateCDO(VIPRoot CDO)
        {
            AdminCDOFile = CDO;
        }
        public static void UploadCDO()
        {
            EncompassApplication.Session.DataExchange.SaveCustomDataObject("VIPCDO.json", new EllieMae.Encompass.BusinessObjects.DataObject(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)AdminCDOFile))));
        }
    }
}
