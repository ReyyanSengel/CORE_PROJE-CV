using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class ExperienceAjaxController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceAjaxController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(_experienceService.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            _experienceService.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetByID(int ExperienceID)
        {
            var values = _experienceService.TGetById(ExperienceID);
            var valuesjson = JsonConvert.SerializeObject(values);
            return Json(valuesjson);
        }

        public IActionResult DeleteExperience(int id)
        {
            var deleted = _experienceService.TGetById(id);
            _experienceService.TDelete(deleted);
            return NoContent();
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience p)
        {
            var values = _experienceService.TGetById(p.ExperienceID);
            _experienceService.TUpdate(values);
            var valuesjson = JsonConvert.SerializeObject(p);
            return Json(valuesjson);

        }
    }
}
