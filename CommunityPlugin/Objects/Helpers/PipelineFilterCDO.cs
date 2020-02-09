using EllieMae.Encompass.Automation;
using EllieMae.Encompass.BusinessObjects;
using Newtonsoft.Json;
using System.Text;

namespace CommunityPlugin.Objects.Helpers
{
    public class PipelineFilterCDO
    {
        private static PipelineFilterCDORoot PipelineCDOFile;

        public static PipelineFilterCDORoot CDO
        {
            get
            {
                if (PipelineCDOFile == null)
                    DownloadCDO();

                return PipelineCDOFile;
            }
        }

        private static void DownloadCDO()
        {
            PipelineCDOFile = JsonConvert.DeserializeObject<PipelineFilterCDORoot>(Encoding.UTF8.GetString(EncompassApplication.Session.DataExchange.GetCustomDataObject("PipelineFilterCDO.json").Data));
        }

        public static void UpdateCDO(PipelineFilterCDORoot CDO)
        {
            PipelineCDOFile = CDO;
        }
        public static void UploadCDO()
        {
            EncompassApplication.Session.DataExchange.SaveCustomDataObject("PipelineFilterCDO.json", new DataObject(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object)PipelineCDOFile))));
        }
    }
}
