﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        public string CusomerName { get; set; }
        
        public string CusomerSurname { get; set; }
        
        public string CusomerDistrict { get; set; }
        
        public string CusomerCity { get; set; }

        public List<Order> Orders { get; set; }

        public bool CustomerStatus { get; set; }

    }
}
