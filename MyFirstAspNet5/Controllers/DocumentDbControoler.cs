using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace MyFirstAspNet5.Controllers
{
    public class DocumentDbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
       {
       return this.View();
       }
       
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
