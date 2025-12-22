using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } // Otomatik artan olduğunu sonundaki "Id" den anlıyor. !!!, evet "Id" var ise otomatik artan oluyor.
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

/*
 Field - Variable - Property
 */


/*
 int x; ---> Field
 public int y {get; set; } --> Property

 void test(){
 {
    int x; --> Local Variable
 }

*/