using System;
using Newtonsoft.Json;

namespace Clockify_API_Client_Core.UserClasses
{
    internal class MembershipTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MembershipType) || t == typeof(MembershipType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "PROJECT":
                    return MembershipType.Project;
                case "USERGROUP":
                    return MembershipType.Usergroup;
                case "WORKSPACE":
                    return MembershipType.Workspace;
            }
            throw new Exception("Cannot unmarshal type MembershipType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MembershipType)untypedValue;
            switch (value)
            {
                case MembershipType.Project:
                    serializer.Serialize(writer, "PROJECT");
                    return;
                case MembershipType.Usergroup:
                    serializer.Serialize(writer, "USERGROUP");
                    return;
                case MembershipType.Workspace:
                    serializer.Serialize(writer, "WORKSPACE");
                    return;
            }
            throw new Exception("Cannot marshal type MembershipType");
        }

        public static readonly MembershipTypeConverter Singleton = new MembershipTypeConverter();
    }
}
