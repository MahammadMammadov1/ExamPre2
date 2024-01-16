using ExamPre2.Business.CustomExceptions;
using ExamPre2.Business.Service.Interfaces;
using ExamPre2.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamPre2.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class FeaturesController : Controller
    {
        private readonly IFeaturesService _featuresService;

        public FeaturesController(IFeaturesService featuresService)
        {
            _featuresService = featuresService;
        }
        public async Task<IActionResult> Index()
        {
            var ftr =  await _featuresService.GetAllAsync();
            return View(ftr);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Create(Features features)
        {
            try
            {
                await _featuresService.CreateAsync(features);
            }
            catch (FeaturesNullException ex)
            {
                return NotFound(ex.Message);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var ftr = await _featuresService.GetByIdAsync(id);
            if (ftr == null) return NotFound();
            return View(ftr);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Features  features)
        {
            try
            {
                await _featuresService.UpdateAsync(features);
            }
            catch (FeaturesNullException ex)
            {

                return NotFound(ex.Message);
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            await _featuresService.DeleteAsync(id);
            return RedirectToAction("index");
        }

    }
}
