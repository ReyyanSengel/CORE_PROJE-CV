using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            var updated = _aboutService.TGetById(1);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Index(About p)
        {
            _aboutService.TUpdate(p);
            return RedirectToAction("Index", "Default");
        }
    }
}
