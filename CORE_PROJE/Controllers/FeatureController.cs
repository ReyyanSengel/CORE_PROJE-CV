using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            var updated = _featureService.TGetById(1);
            return View(updated);
        }
        [HttpPost]
        public IActionResult Index(Feature p)
        {
            _featureService.TUpdate(p);
            return RedirectToAction("Index", "Default");
        }







    }

}
