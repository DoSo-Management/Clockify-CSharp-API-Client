using Newtonsoft.Json;

namespace clockify_core
{
    public partial class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        //	[JsonProperty("memberships")]
        //	public Membership[] Memberships { get; set; }

        [JsonProperty("activeWorkspace")]
        public string ActiveWorkspace { get; set; }

        [JsonProperty("defaultWorkspace")]
        public string DefaultWorkspace { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
    public partial class User
    {
        public static User[] FromJson(string json) => JsonConvert.DeserializeObject<User[]>(json, Converter.Settings);
    }
}