using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace CSharpEgitimKampi601.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // Genelde 64 ile başlayan ObjectId dir
        // Benzersiz bir anahtardır, Her table'da dahi farklıdır ObjectId anahtar oluşturma algoritması ile oluşturulur
        // 12 byte'dır
        public string CustomerId { get; set; } // MongoDb de id'ler string olarak tutuluyor!

        public string CustomerName { get; set; }

        public string  CustomerSurname { get; set; }

        public string CustomerCity { get; set; }

        public decimal CustomerBalance { get; set; }

        public int CustomerShoppingCount { get; set; }
    }
}
