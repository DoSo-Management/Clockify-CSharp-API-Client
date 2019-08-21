using Newtonsoft.Json;

namespace Clockify_API_Client_Core.UserClasses
{
    public partial class HourlyRate
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
