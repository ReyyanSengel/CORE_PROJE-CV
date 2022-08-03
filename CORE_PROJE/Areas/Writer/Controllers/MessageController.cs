using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class MessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(IWriterMessageService writerMessageService, UserManager<WriterUser> userManager)
        {
            _writerMessageService = writerMessageService;
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var receiverlist = _writerMessageService.GetListReceiverMessage(p);
            return View(receiverlist);
        }

        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var senderlisted = _writerMessageService.GetListSenderrMessage(p);
            return View(senderlisted);
        }

       
        public IActionResult SenderMesssageDetails(int id)
        {
            var details = _writerMessageService.TGetById(id);
            return View(details);
        }

        public IActionResult ReceiverMesssageDetails(int id)
        {
            var details = _writerMessageService.TGetById(id);
            return View(details);
        }

        [HttpGet]
        public IActionResult AddMessage()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + "" + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            _writerMessageService.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
