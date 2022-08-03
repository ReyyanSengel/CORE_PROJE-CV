using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Dashboard
{
    public class ProjectList:ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public ProjectList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var listed = _portfolioService.TGetList();
            return View(listed);
        }
    }
}
