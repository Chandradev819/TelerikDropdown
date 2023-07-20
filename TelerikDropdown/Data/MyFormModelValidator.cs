using FluentValidation;
using static TelerikDropdown.Pages.AutoSave;

namespace TelerikDropdown.Data
{
    public class MyFormModelValidator : AbstractValidator<MyFormModel>
    {
        public MyFormModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.MobileNumber).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.State).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();
        }
    }
}
