using Clockify_API_Client_Core.UserClasses;
using Newtonsoft.Json;

namespace Clockify_API_Client_Core.UserClasses
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
