using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            
            var listed = _experienceService.TGetList();
            return View(listed);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            _experienceService.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
           var deleted= _experienceService.TGetById(id);
            _experienceService.TDelete(deleted);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
           
            var updated = _experienceService.TGetById(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Experience p)
        {
            _experienceService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
