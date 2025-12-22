using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    // Logic kurallar arttırılabilir.
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal; // '_' kullanılmazsa this. kullanılmalı 

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            // throw new NotImplementedException();
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            // throw new NotImplementedException();
            
            // if(yetki var ise){
            //    listeleme yap.
            // }
            // else { 
            //    Uyarı ver.
            // }

            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            // throw new NotImplementedException();
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            // throw new NotImplementedException();
            if(entity.CustomerName != "" && entity.CustomerName.Length >= 3 &&
                entity.CustomerCity != null && entity.CustomerSurname != "" &&
                entity.CustomerName.Length <= 30)
            {   // validation just a little(these are done automaticly by libraries in real world)
                // Insert process is done!
                _customerDal.Insert(entity);
            }
            else
            {
                // Throw an error!
            }
        }

        public void TUpdate(Customer entity)
        {
            // throw new NotImplementedException();
            if (entity.CustomerName != "" && entity.CustomerName.Length >= 3 &&
                entity.CustomerCity != null && entity.CustomerSurname != "" &&
                entity.CustomerName.Length <= 30)
            { // Need validation again cause the customer updates his/her infos.
                _customerDal.Update(entity);
            }
            else
            {
                // Throw an error!
            }
        } 
    }
}