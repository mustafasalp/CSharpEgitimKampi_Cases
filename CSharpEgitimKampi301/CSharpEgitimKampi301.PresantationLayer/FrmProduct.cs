using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresantationLayer
{
    public partial class FrmProduct : Form
    {

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
        public void loadProducts()
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategoryID.DataSource = values;
            cmbCategoryID.DisplayMember = "CategoryName";
            cmbCategoryID.ValueMember = "CategoryId";
        }

        private void txtProductDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values; 
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductID.Text);
            var deletedValue = _productService.TGetById(id);
            _productService.TDelete(deletedValue);
            MessageBox.Show($"{deletedValue.ProductName} isimli ürün products tablosundan kaldırıldı.");
            loadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbCategoryID.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductDescription = txtProductDescription.Text;
            product.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TInsert(product);
            MessageBox.Show($"{product.ProductName} isimli ürün products tablosuna eklendi");
            loadProducts();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            //    int id = int.Parse(txtCategoryId.Text);
            //    var values = _categoryService.TGetById(id);
            //    dataGridView1.DataSource = values;

            int id = int.Parse(txtProductID.Text);
            var values = _productService.TGetById(id);
            dataGridView1.DataSource = values; // There is a problem here, We'll fix it later.
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Category category = new Category();
            //int updatedId = int.Parse(txtCategoryId.Text); // Güncellenecek Category'nin Id sini al.
            //var updatedValue = _categoryService.TGetById(updatedId); // Güncellenecek Category'i bul.
            //string preCategoryName = updatedValue.CategoryName;
            //updatedValue.CategoryName = txtCategoryName.Text; // Gücellenecek Category'nin name'ini girilen ile değiştir.
            //updatedValue.CategoryStatus = true; // Stock'da olsun.
            //_categoryService.TUpdate(updatedValue); // TUpdate çağır.
            //MessageBox.Show($"{preCategoryName} isimli kategori, {updatedValue.CategoryName} olarak değiştirildi.");
            //LoadCategories();

            Product product = new Product();
            int updatedId = int.Parse(txtProductID.Text);
            var updatedValue = _productService.TGetById(updatedId); // updatedValue = Güncellenmesi gereken product'ın değerleri var.
            updatedValue.CategoryId = int.Parse(cmbCategoryID.SelectedValue.ToString());
            string preProductName = updatedValue.ProductName;
            updatedValue.ProductName = txtProductName.Text;
            updatedValue.ProductPrice = decimal.Parse(txtProductPrice.Text);
            updatedValue.ProductDescription = txtProductDescription.Text;
            updatedValue.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TUpdate(updatedValue);
            MessageBox.Show($"{preProductName} isimli ürün {updatedValue.ProductName} ismi ile başarıyla güncellendi");
            loadProducts();
        }

        private void cmbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
