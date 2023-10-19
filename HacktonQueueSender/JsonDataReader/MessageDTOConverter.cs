using DTOs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacktonQueueSender.JsonDataReader
{

    public class MessageDTOConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(MessageDTO);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var data = jsonObject["data"] as JObject;

            if (data == null)
            {
                throw new InvalidOperationException("Missing 'data' property in JSON.");
            }

            var analyticsName = jsonObject["AnalyticsName"].ToString();

            var message = new MessageDTO
            {
                AnalyticsName = analyticsName
            };

            // Determine the appropriate concrete type based on "AnalyticsName"
            switch (analyticsName)
            {
                case "Events":
                    message.data = data.ToObject<DataEventDTO>();
                    break;
                case "Sessions":
                    message.data = data.ToObject<DataSessionDTO>();
                    break;
                case "Users":
                    message.data = data.ToObject<DataUserDTO>();
                    break;
                default:
                    throw new InvalidOperationException($"Unknown analytics name: {analyticsName}");
            }

            return message;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
