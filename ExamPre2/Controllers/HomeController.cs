using ExamPre2.Data.DAL;
using ExamPre2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamPre2.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(AppDbContext appDb)
        {
            _appDb = appDb;
        }
        private readonly AppDbContext _appDb;

       

        public IActionResult Index()
        {
            var feat = _appDb.Feauteres.ToList();
            return View(feat);
        }

       
    }
}