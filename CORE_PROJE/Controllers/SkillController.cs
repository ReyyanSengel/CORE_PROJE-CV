using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
           

            var list = _skillService.TGetList();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            _skillService.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted=_skillService.TGetById(id);
            _skillService.TDelete(deleted);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
           
            var updated = _skillService.TGetById(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Skill p)
        {
            
            _skillService.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
