using CommunityPlugin.Objects.Models;
using EllieMae.Encompass.Automation;
using Newtonsoft.Json;
using System.Text;

namespace CommunityPlugin.Objects.Helpers
{
    public class FilterCDOHelper
    {
        private const string Name = "FilterSettings.json";
        private static FilterCDO File;

        public static FilterCDO CDO => File ?? DownloadCDO();

        public static FilterCDO DownloadCDO()
        {
            File = JsonConvert.DeserializeObject<FilterCDO>(Encoding.UTF8.GetString(EncompassApplication.Session.DataExchange.GetCustomDataObject(Name).Data));
            return File;
        }

        public static void UpdateCDO(FilterCDO CDO)
        {
            File = CDO;
        }

        public static void UploadCDO()
        {
            EncompassApplication.Session.DataExchange.SaveCustomDataObject(Name, new EllieMae.Encompass.BusinessObjects.DataObject(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)File))));
        }
    }
}
