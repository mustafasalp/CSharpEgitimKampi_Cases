using CSharpEgitimKampi501.DTOs;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=LAPTOP-AQHLCO74\\SQLEXPRESS;" +
            "initial Catalog=EgitimKampi501Db;integrated Security=true");

        private void ClearTextBoxes()
        {
            txtProductCategory.Clear();
            txtProductName.Clear();
            txtProductID.Clear();
            txtProductPrice.Clear();
            txtProductStock.Clear();
        }

        private async void LoadProducts()
        {
            string query = "SELECT * FROM TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            // Verilen sınıf "ResultProductDto" -> verilen "query" ile mapping olacak.
            // Yani query den gelen ProductPrice bilgisi, ResultProductDto -> ProductPrice'a yazılacak.
            dataGridView1.DataSource = values;
        }

        private async void btnList_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) VALUES" +
                "(@productName, @productStock, @productPrice, @productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCategory", txtProductCategory.Text);

            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show($"{txtProductName.Text} isimli yeni Kitap başarıyla eklendi");
            LoadProducts();
            ClearTextBoxes();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TblProduct WHERE ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtProductID.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show($"{txtProductID.Text} Id'li Kitap başarıyla silindi");
            LoadProducts();
            ClearTextBoxes();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TblProduct SET ProductName=@productName,ProductStock=@productStock," +
                "ProductPrice=@productPrice,ProductCategory=@productCategory WHERE ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCategory", txtProductCategory.Text);
            parameters.Add("@productId", txtProductID.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show($"{txtProductID.Text} Id'li Kitap {txtProductName.Text} ismi ile başarıyla güncellendi","Güncelleme",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoadProducts();
            ClearTextBoxes();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM TblProduct";
            //var values = await connection.QueryAsync<ResultProductDto>(query);
            //// Verilen sınıf "ResultProductDto" -> verilen "query" ile mapping olacak.
            //// Yani query den gelen ProductPrice bilgisi, ResultProductDto -> ProductPrice'a yazılacak.

            string query = "SELECT COUNT(*) FROM TblProduct"; // TblProduct Table'ında kaç tane ürün objesi oldunu döndürür. 
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query);
            lblTotalProductCount.Text = productTotalCount.ToString();

            string query2 = "SELECT ProductName FROM TblProduct WHERE ProductPrice=(SELECT Max(ProductPrice) FROM TblProduct)";
            var maxPriceProductNames = await connection.QueryAsync<string>(query2);
            lblMaxPriceProductName.Text = string.Join(",", maxPriceProductNames);
        
        
            string query3 = "SELECT Count(Distinct(ProductCategory)) From TblProduct";
            var distinctCategoryCount = await connection.QueryFirstOrDefaultAsync<int>(query);
            lblDistinctCategoryCount.Text = distinctCategoryCount.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
