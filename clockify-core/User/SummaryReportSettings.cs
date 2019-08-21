using Newtonsoft.Json;

namespace clockify_core
{
    public partial class SummaryReportSettings
    {
        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }
    }

}
