using CommunityPlugin.Objects.Models;
using EllieMae.Encompass.Automation;
using EllieMae.Encompass.BusinessObjects;
using Newtonsoft.Json;
using System.Text;

namespace CommunityPlugin.Objects.Helpers
{
    public class AutoMailerCDO
    {
        private static AutoMailerCDORoot MailerCDOFiler;
        private static string FileName = "AutoMailerCDO.json";

        public static AutoMailerCDORoot CDO
        {
            get
            {
                if (MailerCDOFiler == null)
                    DownloadCDO();

                return MailerCDOFiler;
            }
        }

        private static void DownloadCDO()
        {
            MailerCDOFiler = JsonConvert.DeserializeObject<AutoMailerCDORoot>(Encoding.UTF8.GetString(EncompassApplication.Session.DataExchange.GetCustomDataObject(FileName).Data));
        }

        public static void UpdateCDO(AutoMailerCDORoot CDO)
        {
            MailerCDOFiler = CDO;
        }
        public static void UploadCDO()
        {
            EncompassApplication.Session.DataExchange.SaveCustomDataObject(FileName, new DataObject(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)Helpers.AutoMailerCDO.MailerCDOFiler))));
        }
    }
}
