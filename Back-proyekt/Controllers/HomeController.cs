using Back_proyekt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Back_proyekt.Controllers
{
    public class HomeController : Controller
    {
        private static List<Product> products;

        public HomeController()
        {
            products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Apple 256gb", Rating = 4, Price = 240, ImageUrl = "index-item 1.jpg" });
            products.Add(new Product { Id = 2, Name = "Composite Product", Rating = 5, Price = 2150, ImageUrl = "index-item 2.jpg" });
            products.Add(new Product { Id = 3, Name = "Webcam HD 720p", Rating = 4, Price = 5240, ImageUrl = "index-item3.jpg" });
            products.Add(new Product { Id = 4, Name = "Portable Wi-Fi Speaker", Rating = 1, Price = 5240, ImageUrl = "index-item 4.jpg" });
            products.Add(new Product { Id = 5, Name = "Acer Laptop", Rating = 2, Price = 1040, ImageUrl = "index-item6.jpg" });
        }
        public IActionResult Index()
        {
            return View(products);
            // return View();
            // return RedirectToAction("Detail");
        }

        public IActionResult Detail(int? id)
        {
            if (id is null) return NotFound();
            Product product = products.Find(p => p.Id == id);
            if (product is null) return NotFound();
            return View(product);
        }
    }
}
 