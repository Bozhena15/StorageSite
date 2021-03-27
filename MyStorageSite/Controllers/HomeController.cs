using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStorageSite.Models;
namespace MyStorageSite.Controllers
{
    public class HomeController : Controller
    {
        StorageContext context;
        public HomeController(StorageContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Buy(int? Id)
        {
            if (Id == null)
                return RedirectToAction("AllProducts");
            ViewBag.ProductId = Id;
            return View();
        }
        
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            if (ModelState.IsValid)
            {
                Order order1 = new Order();
                order1.Address = order.Address;
                order1.contactPhone = order.contactPhone;
                order1.OrderData = DateTime.Now;
                order1.Products = context.Products.Select(p => p).
                    Where(p => p.Id == order.Products.Id).First();

                context.Orders.Add(order1);
                context.SaveChanges();
                return View();
            }
            return View();
        }

        public IActionResult AllOrders()
        {
            return View(context.Orders.ToList());
        }
        public IActionResult AllProducts()
        {
            return View(context.Products.ToList());
        }

    }
}
