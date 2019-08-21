using Newtonsoft.Json;

namespace clockify_core
{
    public partial class Membership
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("hourlyRate")]
        public HourlyRate HourlyRate { get; set; }

        [JsonProperty("targetId")]
        public string TargetId { get; set; }

        [JsonProperty("membershipType")]
        public MembershipType MembershipType { get; set; }

        [JsonProperty("membershipStatus")]
        public MembershipStatus MembershipStatus { get; set; }
    }
}
