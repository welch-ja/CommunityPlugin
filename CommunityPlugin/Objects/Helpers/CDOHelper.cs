using CommunityPlugin.Objects.Models;
using EllieMae.Encompass.Automation;
using Newtonsoft.Json;
using System.Text;

namespace CommunityPlugin.Objects.Helpers
{
    public class CDOHelper
    {
        private const string Name = "CommunitySettings.json";
        private static CDO File;

        public static CDO CDO => File ?? DownloadCDO();

        private static CDO DownloadCDO()
        {
            File = JsonConvert.DeserializeObject<CDO>(Encoding.UTF8.GetString(EncompassApplication.Session.DataExchange.GetCustomDataObject(Name).Data));
            return File;
        }

        public static void UpdateCDO(CDO CDO)
        {
            File = CDO;
        }

        public static void UploadCDO()
        {
            EncompassApplication.Session.DataExchange.SaveCustomDataObject(Name, new EllieMae.Encompass.BusinessObjects.DataObject(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)File))));
        }
    }
}
