using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using quizzApp.Models;

namespace quizzApp.Controllers {
    public class ProductController: Controller {
        public IActionResult ShowAll() {
            ViewData["Heading"] = "All Products";
            var products = new List<Product>();
            products.Add(new Product{ ID = 101, Name = "Apple", Price = 1.1 });
            products.Add(new Product{ ID = 102, Name = "Orange", Price = 9.1 });
            products.Add(new Product{ ID = 103, Name = "Melon", Price = 2.1 });
            return View(products);
        }
    }
}