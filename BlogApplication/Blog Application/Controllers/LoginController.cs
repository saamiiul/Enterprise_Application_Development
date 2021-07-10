using Blog_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Application.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ViewResult LoginPage(User user)
        {
            if (ModelState.IsValid)
            {
                if(MembersRepository.checkValidMember(user))
                {
                    return View("~/Views/Post/HomePage.cshtml");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Your Email or Password is incorrect.");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Your Email or Password is incorrect.");
                return View();
            }
        }
    }
}
