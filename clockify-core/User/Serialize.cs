using Newtonsoft.Json;

namespace clockify_core
{
    public static class Serialize
    {
        public static string ToJson(this User[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
