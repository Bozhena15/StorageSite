using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStorageSite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public virtual Category Category { get; set; }
        //public Order Order { get; set; }
    }
}
