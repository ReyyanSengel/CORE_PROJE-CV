using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        private readonly IWriterMessageService _writerMessageService;

        public AdminNavbarMessageList(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
        }

        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values = _writerMessageService.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            return View(values);
        }
    }
}
