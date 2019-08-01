using Microsoft.AspNetCore.Mvc;
using quizzApp.Models;

 namespace quizzApp.Controllers {
    public class LoginController: Controller {

        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult  Login(Login model) {
            if(model.email == "user@example.com" && model.password == "asdfjkl")
                return View("../Test/Bar");
            else
            {
                return View("../Test/Foo");
            }
        }
    }
}
