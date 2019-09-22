using MediatR;

namespace NonProfit.Application.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery : IRequest<EventDetailModel>
    {
        public int EventId { get; set; }
    }
}