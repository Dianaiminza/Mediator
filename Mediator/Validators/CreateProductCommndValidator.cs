using FluentValidation;
using Mediator.Features.ProductFeatures.Commands;

namespace Mediator.Validators
{
    public class CreateProductCommndValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommndValidator()
        {
            RuleFor(c => c.Barcode).NotEmpty().WithMessage("{Barcode} should be not empty. NEVER!");
            RuleFor(c => c.Name).NotEmpty().WithMessage("{Name} should be not empty. NEVER!").Length(2, 25);
        }
    }
}
