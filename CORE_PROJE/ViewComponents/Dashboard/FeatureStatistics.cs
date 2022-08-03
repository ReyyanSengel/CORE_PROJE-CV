using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        private readonly Context _context;
        public FeatureStatistics(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Skills.Count();
            ViewBag.v2 = _context.Messages.Where(x=>x.Status==false).Count();
            ViewBag.v3 = _context.Messages.Where(x=>x.Status==true).Count();
            ViewBag.v4 = _context.Experiences.Count();
            return View();
        }

    }
}
