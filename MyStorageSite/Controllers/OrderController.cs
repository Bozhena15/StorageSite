using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStorageSite.Models;
namespace MyStorageSite.Controllers
{
    public class OrderController : Controller
    {
        StorageContext context;
        public OrderController(StorageContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
                return RedirectToAction("AllOrders");

            ViewBag.OrderId = id;

            Order order = context.Orders.Select(o => o).Where(o => o.Id == id).First();
            return View(order);
        }
        [HttpGet]
        public IActionResult EditOrder(int? id)
        {
            if (id == null)
                return RedirectToAction("AllOrders");

            ViewBag.OrderId = id;

            Order order = context.Orders.Select(o => o).Where(o => o.Id == id).First();
            return View(order);
        }
        [HttpPost]
        public IActionResult EditOrder(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult DeleteOrder(int? id)
        {
            if (id == null)
                return RedirectToAction("AllOrders");

            ViewBag.OrderId = id;

            Order order = context.Orders.Select(o => o).Where(o => o.Id == id).First();

            context.Orders.Remove(order);
            context.SaveChanges();
            return View();
        }
    }
}
