using CommunityPlugin.Objects.Models;
using EllieMae.Encompass.Automation;
using Newtonsoft.Json;
using System.Text;

namespace CommunityPlugin.Objects.Helpers
{
    public class RuleCDOHelper
    {
        private const string Name = "RuleLockSettings.json";
        private static RuleLockCDO File;

        public static RuleLockCDO CDO => File ?? DownloadCDO();

        public static RuleLockCDO DownloadCDO()
        {
            File = JsonConvert.DeserializeObject<RuleLockCDO>(Encoding.UTF8.GetString(EncompassApplication.Session.DataExchange.GetCustomDataObject(Name).Data));
            return File;
        }

        public static void UpdateCDO(RuleLockCDO CDO)
        {
            File = CDO;
        }

        public static void UploadCDO()
        {
            EncompassApplication.Session.DataExchange.SaveCustomDataObject(Name, new EllieMae.Encompass.BusinessObjects.DataObject(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)File))));
        }
    }
}
