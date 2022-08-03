using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolioService.TGetList();
            return View(values);
        }
    }
}
