using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Clockify_API_Client_Core.UserClasses
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                //MembershipStatusConverter.Singleton,
                //MembershipTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
