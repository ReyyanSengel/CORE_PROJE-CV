using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Dashboard
{
    public class AdminNotificationNavbarList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
