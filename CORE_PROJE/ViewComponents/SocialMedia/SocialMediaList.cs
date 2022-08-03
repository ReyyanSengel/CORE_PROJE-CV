using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaList(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var listed = _socialMediaService.TGetList();
            return View(listed);
        }
    }
}
