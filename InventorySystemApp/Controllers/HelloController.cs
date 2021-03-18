using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
}
