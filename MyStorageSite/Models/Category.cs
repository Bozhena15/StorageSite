using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStorageSite.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
