using FluentValidation;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanını boş bırakamazsınız")
                               .MaximumLength(100).WithMessage("Başlık alanı 100 karakterden fazla olamaz");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanını boş bırakamazsınız")
                                     .MaximumLength(1000).WithMessage("Açıklama alanı 1000 karakterden fazla olamaz");

            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel alanını boş bırakamazsınız");
        }
    }
}
