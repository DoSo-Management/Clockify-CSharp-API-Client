using Newtonsoft.Json;

namespace clockify_core
{
    public partial class HourlyRate
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
