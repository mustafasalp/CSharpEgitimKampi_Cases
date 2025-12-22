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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresantationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()// Parametresiz constructor yap.
        {
            _categoryService = new CategoryManager(new EfCategoryDal()); // EfCategoryDal sınıfından bir nesne oluştur, 
            InitializeComponent();
        }

        public void LoadCategories()
        {
            var categoryValues = _categoryService.TGetAll(); // Tüm Category'leri list olarak getir.
            dataGridView1.DataSource = categoryValues; // DataGridView de bunları göster.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;    
            category.CategoryStatus = true;
            _categoryService.TInsert(category); // Buradaki TInsert() business katmanındaki Insert()'in abstract edilmiş hali.
            MessageBox.Show($"{category.CategoryName} isimli kategori başarıyla eklendi.");
            LoadCategories();
        }
            
        private void rdbActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show($"{deletedValues.CategoryName} isimli kategori başarıyla Silindi.");
            LoadCategories();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            int updatedId = int.Parse(txtCategoryId.Text); // Güncellenecek Category'nin Id sini al.
            var updatedValue = _categoryService.TGetById(updatedId); // Güncellenecek Category'i bul.
            string preCategoryName = updatedValue.CategoryName;
            updatedValue.CategoryName = txtCategoryName.Text; // Gücellenecek Category'nin name'ini girilen ile değiştir.
            updatedValue.CategoryStatus = true; // Stock'da olsun.
            _categoryService.TUpdate(updatedValue); // TUpdate çağır.
            MessageBox.Show($"{preCategoryName} isimli kategori, {updatedValue.CategoryName} olarak değiştirildi.");
            LoadCategories();
        }
    }
}
