using DTOs;
using HacktonSQS;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DataBase
{
    public class MongoDBHandler
    {
        private readonly IMongoDatabase database;
        private readonly MongoConfig _mongoConfigManager;

        private readonly string EventsCollectionName = "Events";
        private readonly string UsersCollectionName = "Users";
        private readonly string SessionsCollectionName = "Sessions";

        public MongoDBHandler()
        {
            _mongoConfigManager = MongoConfig.Instance;
            var client = new MongoClient(_mongoConfigManager.ConnectionString);
            database = client.GetDatabase(_mongoConfigManager.DatabaseName);
        }

        public void ProcessMessageToDB(string collectionName, DataInterface data)
        {
            if (collectionName == EventsCollectionName)
            {
                InsertData(EventsCollectionName, data as DataEventDTO);
            }
            else if (collectionName == UsersCollectionName)
            {
                InsertData(UsersCollectionName, data as DataUserDTO);
            }
            else if (collectionName == SessionsCollectionName)
            {
                InsertData(SessionsCollectionName, data as DataSessionDTO);
            }
        }

        private void InsertData<T>(string collectionName, T data)
        {
            var collection = database.GetCollection<T>(collectionName);
            collection.InsertOne(data);
        }
    }

}
