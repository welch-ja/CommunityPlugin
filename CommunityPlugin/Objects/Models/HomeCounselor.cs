using Newtonsoft.Json;

namespace CommunityPlugin.Objects.Models
{
    public class HomeCounselor
    {
        [JsonProperty("languages")]
        public string Languages { get; set; }

        [JsonProperty("agcid")]
        public string AgencyID { get; set; }

        [JsonProperty("adr1")]
        public string Address1 { get; set; }

        [JsonProperty("adr2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("statecd")]
        public string State { get; set; }

        [JsonProperty("weburl")]
        public string WebURL { get; set; }

        [JsonProperty("zipcd")]
        public string ZipCode { get; set; }

        [JsonProperty("agc_ADDR_LATITUDE")]
        public string Latitude { get; set; }

        [JsonProperty("agc_ADDR_LONGITUDE")]
        public string Longitude { get; set; }

        [JsonProperty("parentid")]
        public string ParentID { get; set; }

        [JsonProperty("county_NME")]
        public string County { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("mailingadr1")]
        public string MailingAddress1 { get; set; }

        [JsonProperty("mailingadr2")]
        public string MailingAddress2 { get; set; }

        [JsonProperty("mailingcity")]
        public string MailingCity { get; set; }

        [JsonProperty("mailingzipcd")]
        public string MailingZipCode { get; set; }

        [JsonProperty("mailingstatecd")]
        public string MailingState { get; set; }

        [JsonProperty("state_NME")]
        public string StateNME { get; set; }

        [JsonProperty("state_FIPS_CODE")]
        public string StateFIPSCode { get; set; }

        [JsonProperty("faithbased")]
        public string FaithBased { get; set; }

        [JsonProperty("colonias_IND")]
        public string ColoniasIND { get; set; }

        [JsonProperty("migrantwkrs_IND")]
        public string MigrantWorkers { get; set; }

        [JsonProperty("agc_STATUS")]
        public string AGStatus { get; set; }

        [JsonProperty("agc_SRC_CD")]
        public string AGSourceCD { get; set; }

        [JsonProperty("counslg_METHOD")]
        public string CounselingMethod { get; set; }

        [JsonProperty("services")]
        public string Services { get; set; }
    }
}
