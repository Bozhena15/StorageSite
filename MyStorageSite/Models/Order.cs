using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyStorageSite.Models
{
    public class Order
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string User { get; set; } // to do user model
        public string Address { get; set; }
        public string contactPhone { get; set; }
        public DateTime OrderData { get; set; }
        public virtual Product Products { get; set; }
    }
}
