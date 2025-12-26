using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;
        public MongoDbConnection() // Constructor
        {
            var client = new MongoClient("mongodb://localhost:27017/"); // client adres'i tutuyor. -> Bağlantı adresi
            _database = client.GetDatabase("DB601Database"); // Oluşturulan veritabanının ismi.
        }

        public IMongoCollection<BsonDocument> GetCustomersCollection()
        {
            return _database.GetCollection<BsonDocument>("Customers"); // 
            // "Customers" adında "DB601Database" ine bir tablo(mongoDb adıyla "koleksiyon") oluşturacak.
            // Customers isimli collection’ı döndürür
        }
    }   
}