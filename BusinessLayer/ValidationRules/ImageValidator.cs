using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ImageValidator : AbstractValidator<Image>
	{
		public ImageValidator()
		{
			RuleFor(x=>x.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezsiniz!");
			RuleFor(x=>x.Description).NotEmpty().WithMessage("Görsel açıklamasını boş geçemezsiniz!");
			RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz!");
			RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız!");
			RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız!");
			RuleFor(x => x.Description).MaximumLength(70).WithMessage("Lütfen en fazla 70 karakter veri girişi yapınız!");
			RuleFor(x => x.Description).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız!");
		}
	}
}
