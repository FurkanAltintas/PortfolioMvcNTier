using FluentValidation;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.ValidationRules
{
    public class DegreeValidator : AbstractValidator<Degree>
    {
        public DegreeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanını boş bırakamazsınız")
                              .MinimumLength(1).WithMessage("Ad alanı 1 karakterden fazla olması gerekmektedir")
                              .MaximumLength(150).WithMessage("Ad alanı 150 karakterden fazla olması gerekmektedir");
        }
    }
}
