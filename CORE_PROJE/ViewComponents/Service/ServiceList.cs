using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        private readonly IServiceService _service;

        public ServiceList(IServiceService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _service.TGetList();
            return View(values);
        }
    }
}
