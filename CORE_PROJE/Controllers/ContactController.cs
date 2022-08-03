using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var listed = _messageService.TGetList();
            return View(listed);
        }

        public IActionResult DeleteMessage(int id)
        {
            var result = _messageService.TGetById(id);
            _messageService.TDelete(result);
            return RedirectToAction("Index", "Contact");
        }

        public IActionResult ViewMessage(int id)
        {
            var result = _messageService.TGetById(id);
            return View(result);
        }
    }
}
