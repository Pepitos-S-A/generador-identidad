﻿using MongoDB.Driver;

namespace Duisv.Database
{
    internal class MongoDBProvider
    {
        private readonly MongoClient _client;

        public MongoDBProvider()
        {
            _client = new MongoClient(Properties.Settings.Default.MongoDBConnectionString);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName, string databaseName = "pepitosdb")
        {
            return GetDatabase(databaseName).GetCollection<T>(collectionName);
        }

        private IMongoDatabase GetDatabase(string databaseName)
        {
            return _client.GetDatabase(databaseName);
        }
    }
}
