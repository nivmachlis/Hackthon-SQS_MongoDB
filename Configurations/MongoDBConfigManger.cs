using Microsoft.Extensions.Configuration;
using System.IO;

namespace HacktonSQS
{
    public class MongoConfig
    {
        private static MongoConfig instance;
        private MongoConfig() { }

        public static MongoConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MongoConfig();
                    instance.LoadMongoConfig();
                }
                return instance;
            }
        }

        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string EventsCollection { get; set; }
        public string SessionsCollection { get; set; }
        public string MessagesCollection { get; set; }


        private void LoadMongoConfig()
        {
            var configuration = new ConfigurationBuilder()
              .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Configurations"))
              .AddJsonFile(path: "appsettings.json")
              .Build();

            ConnectionString = configuration.GetSection("MongoDB:ConnectionString").Value;
            DatabaseName = configuration.GetSection("MongoDB:DataBase").Value;
        }
    }
}
