using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            
            var listed= _serviceService.TGetList();
            return View(listed);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            _serviceService.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _serviceService.TGetById(id);
            _serviceService.TDelete(deleted);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            
            var updated = _serviceService.TGetById(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Service p)
        {
            _serviceService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
