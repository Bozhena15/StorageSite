using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStorageSite.Models;
namespace MyStorageSite
{
    public class DataTest
    {
        public static void Inizialise(StorageContext storage)
        {
            if (!storage.Products.Any())
            {
                storage.Products.AddRange(
                    new Product { ProductName = "Doll", Price = 120 },
                    new Product { ProductName = "Car", Price = 200 },
                    new Product { ProductName = "House", Price = 700 }
                    );
                storage.SaveChanges();
            }

            if (!storage.Categories.Any())
            {
                var pr = new List<Product>();
                pr.AddRange(storage.Products.ToList());
                storage.Categories.AddRange(
                    new Category { Name = "Toys", Products = pr },
                    new Category { Name = "Phones" }
                    );
                storage.SaveChanges();
            }

            if (!storage.Orders.Any())
            {
                var pr = new Product();
                pr = storage.Products.Select(p => p).Where(p => p.Id == 1).First();
                storage.Orders.Add(
                    new Order { User = "Marianna", Address = "IF", contactPhone = "+380661234567", OrderData = DateTime.Now, Products = pr });
                storage.SaveChanges();
            }
        }
    }
}
