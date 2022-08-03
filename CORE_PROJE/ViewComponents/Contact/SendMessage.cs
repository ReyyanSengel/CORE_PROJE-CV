using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {

        private readonly IMessageService _messageService;

        public SendMessage(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());  //Mesajların yazıldığı tarihi database dahil et
        //    p.Status = true; //aktif mesaj
        //     _messageService.TAdd(p);
        //      return View();
        //}






    }
}
