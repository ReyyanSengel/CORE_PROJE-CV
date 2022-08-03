using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Controllers
{
    public class AdminMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;

        public AdminMessageController(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
        }

        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = _writerMessageService.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = _writerMessageService.GetListSenderrMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = _writerMessageService.TGetById(id);
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var deteded = _writerMessageService.TGetById(id);
            _writerMessageService.TDelete(deteded);
            //if ()
            //{
            //    //ÖDEV BURAYI tamamla,yönlendirmeyi if ile şaerta bağla
            //}
            return RedirectToAction("ReceiverMessageList");
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _writerMessageService.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
