using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_PROJE.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {

        private readonly ISkillService _skillService;

        public SkillList(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _skillService.TGetList();
            return View(values);
        }
    }
}
