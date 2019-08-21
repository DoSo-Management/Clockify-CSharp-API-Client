using Newtonsoft.Json;

namespace Clockify_API_Client_Core.UserClasses
{
    public static class Serialize
    {
        public static string ToJson(this User[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
