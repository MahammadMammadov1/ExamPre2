﻿using Microsoft.AspNetCore.Mvc;

namespace ExamPre2.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
