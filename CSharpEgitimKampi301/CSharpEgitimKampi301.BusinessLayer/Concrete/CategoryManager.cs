// CategoryManager.cs in Business Layer
using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{ 
    public class CategoryManager : ICategoryService 
    {
        private readonly ICategoryDal _categoryDal; // Field -> Class içinde tanımlandığı için.(Sonunda get; set; olsa idi property olcaktı)
        public CategoryManager(ICategoryDal categoryDal) // Constructor method.
        {
            _categoryDal = categoryDal;
        }
        public void TDelete(Category entity)
        {
            if (entity.CategoryId <= 0)
                throw new Exception("Geçersiz kategori id.");
            _categoryDal.Delete(entity); // delete burada bir method.   
        }

        public List<Category> TGetAll()
        {
            //throw new NotImplementedException();
            return _categoryDal.GetAll();
        }
        
        public Category TGetById(int id)
        {
            // throw new NotImplementedException();
            return _categoryDal.GetById(id);
        }
        
        public void TInsert(Category entity)
        {
            if(string.IsNullOrWhiteSpace(entity.CategoryName))
                throw new Exception("Kategori adı boş olamaz.");

            _categoryDal.Insert(entity);
        }
        public void TUpdate(Category entity)
        {
            // throw new NotImplementedException();
            _categoryDal.Update(entity);
        }
        // DataAcces deki methodlar business da çağırıldı.
    }
}
