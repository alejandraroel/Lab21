using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;


namespace CoffeeShop.Controllers

{
    public class RegisterController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new RegistrationViewModel();
            return View("RegisterIndex", model);
        }
        public IActionResult Register(RegistrationViewModel model)
        {
            return View(model);
        }
    }
}