using FluentValidation;

namespace NonProfit.Application.Events.Commands.CreateEvent
{
    public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
    {
        public CreateEventCommandValidator()
        {
            RuleFor(e => e).NotNull();
            RuleFor(e => e.Name).NotEmpty();
            RuleFor(e => e.StartDateTime).NotEmpty();
            RuleFor(e => e.EndDateTime).NotEmpty();
        }
    }
}