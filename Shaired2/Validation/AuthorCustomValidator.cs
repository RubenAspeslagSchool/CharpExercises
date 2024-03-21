using FluentValidation;

namespace Shared.Validation
{
    public class AuthorCustomValidator: AbstractValidator<PublisherWriteDTO>
    {
        public AuthorCustomValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("The first name of the author cannot be blank")
                .Length(2, 50)
                .WithMessage("The first name should be at least 2 characters and cannot be more than 50 characters.");

            RuleFor(a => a.Lastname)
                .NotEmpty()
                .WithMessage("The last name of the author cannot be blank")
                .Length(2, 50)
                .WithMessage("The last Name should be at least 2 characters and cannot be more than 50 characters.");

            RuleFor(a => a.City)
                .Length(0, 80)
                .WithMessage("The place to live cannot be more than 80 characters.")
                .Custom((c, context) => {
                    IEnumerable<string> cities = new List<string> { "Brugge", "Gent", "Leuven" };
                    if (!cities.Contains(c))
                    {
                        context.AddFailure("Wrong city!!");
                    }
                });
        }
    }
}
