using FluentValidation;

namespace NonProfit.Application.Events.Commands.CreateEvent
{
    public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
    {
        public CreateEventCommandValidator()
        {
            RuleFor(e => e).NotNull();
            RuleFor(e => e.EventName).NotEmpty();
            RuleFor(e => e.EventTypeName).NotEmpty();
            RuleFor(e => e.Address1).NotEmpty();
            RuleFor(e => e.City).NotEmpty();
            RuleFor(e => e.State).NotEmpty();
            RuleFor(e => e.Country).NotEmpty();
            RuleFor(e => e.PostalCode).NotEmpty();
            RuleFor(e => e.StartDateTime).NotEmpty();
            RuleFor(e => e.EndDateTime).NotEmpty();
            RuleFor(e => e.Repeat).IsInEnum();
        }
    }
}