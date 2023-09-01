using FluentValidation;
using RestaurantWebUI.Dtos.GuestDto;

namespace RestaurantWebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("soyisim boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("en az 3 karakter giriniz");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("en az 2 karakter giriniz");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("en fazla 20 karakter giriniz");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("en fazla 20 karakter giriniz");
        }
    }
}
