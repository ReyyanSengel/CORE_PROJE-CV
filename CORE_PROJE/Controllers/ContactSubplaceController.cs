using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class ContactSubplaceController : Controller
    {
        private readonly IContactService _contactService;

        public ContactSubplaceController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _contactService.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
             _contactService.TUpdate(p);
            return RedirectToAction("Index","Default");
        }

    }
}
