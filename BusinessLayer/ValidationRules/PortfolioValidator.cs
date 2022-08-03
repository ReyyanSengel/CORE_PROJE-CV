using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.Value).InclusiveBetween(1, int.MaxValue).WithMessage("Değer 0 dan büyük olmalı");
        }
    }
}
