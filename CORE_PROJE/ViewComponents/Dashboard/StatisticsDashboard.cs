using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Dashboard
{
    public class StatisticsDashboard:ViewComponent
    {
        private readonly Context _context;

        public StatisticsDashboard(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.istatistic_1 = _context.Portfolios.Count();
            ViewBag.istatistic_2 = _context.Messages.Count();
            ViewBag.istatistic_3 = _context.Services.Count();
            return View();
        }
    }
}
