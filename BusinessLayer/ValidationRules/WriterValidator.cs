using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçmeyiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soy adını boş geçmeyiniz ");
            RuleFor(x => x.WriterAbout).MaximumLength(500).WithMessage("Hakkında kısmını boş geçmeyiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan boş geçmeyiniz ");
            RuleFor(x => x.WriterMail).MaximumLength(200).WithMessage("Lütfen 200 karakterden fazla değer girmeyiniz");
            RuleFor(x => x.WriterPassword).MaximumLength(200).WithMessage("Lütfen 200 karakterden fazla değer girmeyiniz");
        }
    }
}
