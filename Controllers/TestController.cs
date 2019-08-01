using Microsoft.AspNetCore.Mvc;

namespace quizzApp.Controllers {
    public class TestController: Controller {

        public IActionResult Foo() {
            ViewData["Title"] = "Some Title";
            ViewData["Header"] = "This is my header";
            ViewData["Items"] = "one two three".Split(' ');
            return View();
        }

        public IActionResult Bar() {
            ViewBag.Title = "Bar";
            ViewBag.Header = "Bar Header";
            ViewBag.Items = "four five six".Split(" ");
            return View();
        }
    }
}