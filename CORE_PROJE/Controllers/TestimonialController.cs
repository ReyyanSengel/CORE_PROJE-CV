using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            var listed = _testimonialService.TGetList();
            return View(listed);
        }

        public IActionResult Delete(int id)
        {
            var deleted = _testimonialService.TGetById(id);
            _testimonialService.TDelete(deleted);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            _testimonialService.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var updeted = _testimonialService.TGetById(id);
            return View(updeted);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial p)
        {
            _testimonialService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
