using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations // CustomerOperations Sınıfı
    { 
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection(); // Önce kendi yazdığım "MongoDbConnection" sınıfıyla connection oluşturdum.
            var customerCollection = connection.GetCustomersCollection(); // CustomerCollection'unu alır.

            var document = new BsonDocument
            {
                {"CustomerName", customer.CustomerName},
                {"CustomerSurname", customer.CustomerSurname},
                {"CustomerCity", customer.CustomerCity},
                {"CustomerBalance", customer.CustomerBalance},
                {"CustomerShoppingCount", customer.CustomerShoppingCount}
            };
            // Bir BsonDocument tipinde doküman oluşturdum ve parametre olarak gelen customer'ın değerlerini database' rowlarına mapledim.

            customerCollection.InsertOne(document);
        }
    
        public List<Customer> GetAllCustomers() // GetAllCustomers methodu (CustomerOperations Sınıfı içinde)
        {
            var connection = new MongoDbConnection(); // Önce kendi yazdığım "MongoDbConnection" sınıfıyla connection oluşturdum.
            var customerCollection = connection.GetCustomersCollection(); // CustomerCollection'unu alır. -> Customer Table'ı kısaca.
            var customers = customerCollection.Find(new BsonDocument()).ToList(); // customers değişkeni içine Customer Collection'u(Table'ı) içindeki veriler alındı.
            List<Customer> customerList = new List<Customer>(); // Boş customer listesi oluşturuldu.

            foreach (var c in customers) // c değişkeni customers içini geziyor
            {
                // c değişkeniyle CustomerList'e -> Add ile Customer ekleniyor,
                customerList.Add(new Customer
                {
                    CustomerId = c["_id"].ToString(),
                    CustomerBalance = decimal.Parse(c["CustomerBalance"].ToString()),
                    CustomerCity = c["CustomerCity"].ToString(),
                    CustomerName = c["CustomerName"].ToString(),
                    CustomerSurname = c["CustomerSurname"].ToString(),
                    CustomerShoppingCount = int.Parse(c["CustomerShoppingCount"].ToString())
                });
            }

            return customerList; // Bu liste return ediyor.
        }
    
        public  void DeleteCustomer(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));  // Silinmek istenilen değer bulundu.
            customerCollection.DeleteOne(filter);       
        }
    
        public void UpdateCustomer(Customer customer) // Parametre olarak gönderilen customer' yeni customer
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId)); // Update edilecek Customer bulunur.
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName", customer.CustomerName)
                .Set("CustomerSurname", customer.CustomerSurname)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);

            customerCollection.UpdateOne(filter, updatedValue);
        }

        public Customer GetCustomerById(string id) 
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();

            // Yukarıda connection ayarlanıyor ve o connection dan customer table'ı çekiliyor.

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id)); // Getirilecek customer "id" den bulunuyor. -> ObjectId'si bulunuyor yani.
            var result = customerCollection.Find(filter).FirstOrDefault();  // Bulunan objectId den  Customer Bilgileri çekiliyor.

            return new Customer
            {
                CustomerBalance = decimal.Parse(result["CustomerBalance"].ToString()),
                CustomerName = result["CustomerName"].ToString(),
                CustomerSurname = result["CustomerSurname"].ToString(),
                CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),
                CustomerCity = result["CustomerCity"].ToString(),
            }; // Burada da yeni bir customer dönüyoruz(return ediyoruz) öyle ki customer'ın bilgileri result dan gelene eşit.
        }
    }
}    