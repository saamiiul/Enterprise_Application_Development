using Blog_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Application.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ViewResult SignUpPage()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUpPage(Member m)
        {
            if (ModelState.IsValid)
            {
                MembersRepository.addMember(m);
                return View("Thanks", m);
            }
            else
            {
                return View();
            }
        }
    }
}
