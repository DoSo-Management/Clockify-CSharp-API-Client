using Clockify_API_Client_Core.Models;
using Clockify_API_Client_Core.PersistentObjects;
using DevExpress.Xpo;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Clockify_API_Client_Core.UserClasses
{
    [DebuggerDisplay("{Name}")]
    public class User : MyModelBase
    {
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

        public override MyBase CreatePersistentObject(Session session) =>
                new ClockifyUser(session) { };

        public override MyBase MapToPersistentObject(MyBase obj)
        {
            if (obj is ClockifyUser user)
            {
                user.ActiveWorkspace = ActiveWorkspace;
                user.DefaultWorkspace = DefaultWorkspace;
                user.Email = Email;
                user.Id = Id;
                user.Name = Name;
                user.Status = Status;
            }

            return obj;
        }
        //public partial class User
        //{
        //    public static User[] FromJson(string json) => JsonConvert.DeserializeObject<User[]>(json, Converter.Settings);
        //}
    }
}