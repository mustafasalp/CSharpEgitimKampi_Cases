using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Ders09_DatabaseProject
{
    internal class Program 
    {  
        static void Main(string[] args)
        {
            //ADO.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bİlgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber; 

            Console.WriteLine("------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AQHLCO74\\SQLEXPRESS;" +
                "initial Catalog=EğitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
