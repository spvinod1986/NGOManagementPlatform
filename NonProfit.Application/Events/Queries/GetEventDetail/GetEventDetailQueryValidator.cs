using FluentValidation;

namespace NonProfit.Application.Events.Queries.GetEventDetail
{
    public class GetEventDetailQueryValidator : AbstractValidator<GetEventDetailQuery>
    {
        public GetEventDetailQueryValidator()
        {
            RuleFor(e => e).NotNull();
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}