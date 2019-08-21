using Newtonsoft.Json;

namespace Clockify_API_Client_Core.UserClasses
{
    public partial class SummaryReportSettings
    {
        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }
    }

}
