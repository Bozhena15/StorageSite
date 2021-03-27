using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyStorageSite.Models;
namespace MyStorageSite
{
    public class StorageContext: DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
