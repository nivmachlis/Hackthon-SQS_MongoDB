using DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HacktonSQS.SenderForm;

namespace HacktonQueueSender.JsonDataReader
{
    public static class JsonDataReader
    {
        public static JsonDataDTO ReadJsonFile(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                var rootObject = JsonConvert.DeserializeObject<JsonDataDTO>(jsonContent, new MessageDTOConverter());
                return rootObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
                return null;
            }
        }
    }
}
