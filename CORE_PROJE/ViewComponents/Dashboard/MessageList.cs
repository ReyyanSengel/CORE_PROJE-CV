using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {

        private readonly IMessageService _messageService;

        public MessageList(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _messageService.TGetList();
            return View(values);
        }
    }
}
