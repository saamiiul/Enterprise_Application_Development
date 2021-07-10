using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Application.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Main()
        {
            return View();
        }
    }
}
