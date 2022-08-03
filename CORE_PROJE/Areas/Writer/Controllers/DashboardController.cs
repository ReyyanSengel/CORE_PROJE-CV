using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CORE_PROJE.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        private readonly Context _context;

        public DashboardController(UserManager<WriterUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = values.Name + " " + values.Surname;


            //Weather APİ
            string api = "5d4e32a450449045745e10cd506dc0fe";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            //statistic
            ViewBag.message = _context.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.announcement = _context.Announcements.Count();
            ViewBag.totaluser = _context.Users.Count();
            ViewBag.skill = _context.Skills.Count();
            return View();




        //https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&units=metric&appid=5d4e32a450449045745e10cd506dc0fe
        }
    }
}
