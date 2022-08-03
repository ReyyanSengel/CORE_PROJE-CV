using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            var listed = _socialMediaService.TGetList();
            return View(listed);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            _socialMediaService.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var updated = _socialMediaService.TGetById(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia p)
        {
           
            _socialMediaService.TUpdate(p);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(deleted);
            return RedirectToAction("Index");
        }


    }
}
