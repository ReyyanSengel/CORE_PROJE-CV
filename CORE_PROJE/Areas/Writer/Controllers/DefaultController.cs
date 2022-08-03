using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    [Authorize]
    public class DefaultController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        

        public DefaultController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var listed = _announcementService.TGetList();
            return View(listed);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var detail = _announcementService.TGetById(id);
            return View(detail);
        }
    }
}
