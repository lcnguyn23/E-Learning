﻿using Microsoft.AspNetCore.Mvc;

namespace ELearning.Web.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}