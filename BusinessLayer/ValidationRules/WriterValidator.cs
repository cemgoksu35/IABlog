using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı kısmı boş geçilemez");
			RuleFor(x=> x.WriterMail).NotEmpty().WithMessage("Mail kısmı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter olmalıdır");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter olmalıdır");
        }
	}
}

