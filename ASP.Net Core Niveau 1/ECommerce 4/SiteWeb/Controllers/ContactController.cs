﻿using Microsoft.AspNetCore.Mvc;
using Models.Contact;

namespace SiteWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Formulaire()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Formulaire(FormulaireVM model)
        {
            return View();
        }
    }

}
