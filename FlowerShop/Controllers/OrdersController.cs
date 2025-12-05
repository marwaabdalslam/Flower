using Microsoft.AspNetCore.Mvc;
using FlowerShop.Data;
using FlowerShop.Models;

namespace FlowerShop.Controllers
{
    public class OrdersController : Controller
    {
        private readonly FlowerShopContext _context;
        public OrdersController(FlowerShopContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Orders.ToList());

        public IActionResult Details(int id) => View(_context.Orders.Find(id));

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public IActionResult Edit(int id) => View(_context.Orders.Find(id));

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Update(order);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public IActionResult Delete(int id) => View(_context.Orders.Find(id));

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}