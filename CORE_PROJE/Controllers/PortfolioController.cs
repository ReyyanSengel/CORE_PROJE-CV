using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            
            var listed = _portfolioService.TGetList();
            return View(listed);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            if (ModelState.IsValid)
            {
                _portfolioService.TAdd(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public IActionResult Delete(int id )
        {
            var deleted = _portfolioService.TGetById(id);
            _portfolioService.TDelete(deleted);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            
            var updated = _portfolioService.TGetById(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Portfolio p)
        {
            if (ModelState.IsValid)
            {
                _portfolioService.TUpdate(p);
                return RedirectToAction("Index");
            }
            return View(p);
           
        }
    }
}
