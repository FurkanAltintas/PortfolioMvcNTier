using FluentValidation;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanını boş bırakamazsınız")
                                .MinimumLength(2).WithMessage("Ad alanı 2 karakterden fazla olmalıdır")
                                .MaximumLength(50).WithMessage("Ad alanı 50 karakterden az olmalıdır");

            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyadı alanını boş bırakamazsınız")
                                   .MinimumLength(1).WithMessage("Soyadı alanı 1 karakterden fazla olmalıdır")
                                   .MaximumLength(100).WithMessage("Soyadı alanı 100 karakterden az olmalıdır");

            RuleFor(x => x.FullName).NotEmpty().WithMessage("Kullanıcı adı alanını boş bırakamazsınız")
                                    .MaximumLength(100).WithMessage("Kullanıcı adı 100 karakterden az olmalıdır");

            RuleFor(x => x.AuthorityId).NotEmpty().WithMessage("Yetki alanını boş bırakamazsınız");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanını boş bırakamazsınız")
                               .EmailAddress().WithMessage("Girmiş olduğunuz bilgiler uyuşmuyor")
                               .MaximumLength(100).WithMessage("Mail alanı 100 karakterden az olmalıdır");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez")
                                    .MinimumLength(8).WithMessage("Şifreniz en az 8 karakter olmalıdır")
                                    .MaximumLength(16).WithMessage("Şifreniz en fazla 16 karakter olmalıdır")
                                    .Matches(@"[A-Z]+").WithMessage("Şifrenizde en az 1 büyük harf olmalıdır")
                                    .Matches(@"[a-z]+").WithMessage("Şifrenizde en az 1 küçük harf olmalıdır")
                                    .Matches(@"[0-9]+").WithMessage("Şifrenizde en az bir rakam olmalıdır");
        }
    }
}
