using System;
using Newtonsoft.Json;

namespace clockify_core
{
    internal class MembershipStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MembershipStatus) || t == typeof(MembershipStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "ACTIVE")
            {
                return MembershipStatus.Active;
            }
            throw new Exception("Cannot unmarshal type MembershipStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MembershipStatus)untypedValue;
            if (value == MembershipStatus.Active)
            {
                serializer.Serialize(writer, "ACTIVE");
                return;
            }
            throw new Exception("Cannot marshal type MembershipStatus");
        }

        public static readonly MembershipStatusConverter Singleton = new MembershipStatusConverter();
    }
}
