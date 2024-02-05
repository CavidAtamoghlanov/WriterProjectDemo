using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz");
            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("Başlık alanı en az 3 karakter olmalıdır");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Başlık alanı en fazla 100 karakter olmalıdır");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik alanı boş bırakılamaz");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("İçerik alanı en az 5 karakter olmalıdır");

            RuleFor(x=>x.BlogImage).NotEmpty().WithMessage("Resim alanı boş bırakılamaz");

        }
    }
}
