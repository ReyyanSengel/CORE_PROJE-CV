using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Areas.Writer.ViewComponents
{
    public class Notification:ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public Notification(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            var listed = _announcementService.TGetList();
            return View(listed);
        }
    }
}
