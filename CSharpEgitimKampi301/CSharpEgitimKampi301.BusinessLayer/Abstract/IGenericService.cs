using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where  T: class
    {
        // Interface, bir sınıfın ne yapacağını tanımlar ama nasıl yapacağını söylemez.
        // Sadece metot imzaları, property’ler ve event’ler içerir; gövde (implementation) içermez.

        // Kısa tabirle interface: sözleşme denilebilir. -> ne yapılacak

        // Peki neden ayrıca ICategoryService, ICustomerService var?
        // Çünkü bazı entity’lerin kendine özel işleri vardır

        void TInsert(T entity); // Data access dekiler ile Business deki methodlar karışmasın diye başına T eklenir.

        void TUpdate(T entity);

        void TDelete(T entity);

        List<T> TGetAll();  

        T TGetById(int id);
    }
}
