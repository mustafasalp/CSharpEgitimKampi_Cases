using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Ders10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crud --> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");
            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= LAPTOP-AQHLCO74\\SQLEXPRESS;" +
            //    "initial Catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarı ile eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürünün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürünün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AQHLCO74\\SQLEXPRESS;initial" +  
            //     " Catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName,ProductPrice,ProductStatus) VALUES"
            //   + " (@productName,@productPrice,@ProductStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün Eklemesi Başarılı! "); 

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AQHLCO74\\SQLEXPRESS;" +
            //    "initial Catalog=EğitimKampiDb;integrated security=true");
            // Creates a connection object to your SQL Server. 

            //connection.Open();
            // Opens the stream(connection)

            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);
            // Sets a command

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            // A data adapter is a helper that can bridge between your SQL command and an in-memory DataTable.

            //DataTable dataTable = new DataTable();
            // Create data table

            //adapter.Fill(dataTable);
            // connect adapter with data table

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray) // ItemArray, is an array with fully items in the corresponding row.
            //    {                                   // For example: ItemArray = [1, Mercimek Çorbası, 60, True] 
            //        Console.Write(item.ToString() + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Enter product Id you want to delete: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AQHLCO74\\SQLEXPRESS;" +
            //    "initial Catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("The Id is deleted! ");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Enter ProductId: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Enter ProductName: ");
            //string productName = Console.ReadLine();

            //Console.Write("Enter ProductPrice: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AQHLCO74\\SQLEXPRESS;" +
            //    "initial Catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName,ProductPrice=@productPrice" +
            //    " WHERE ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Updated succesfuly! ");

            #endregion

            Console.Read();

        }
    }
}
