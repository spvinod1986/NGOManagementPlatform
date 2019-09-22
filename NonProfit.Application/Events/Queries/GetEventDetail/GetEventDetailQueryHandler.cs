using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NonProfit.Application.Exception;
using NonProfit.Domain.Entities;
using NonProfit.Persistence;

namespace NonProfit.Application.Events.Queries.GetEventDetail
{
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailModel>
    {
        private readonly NonProfitContext _context;

        public GetEventDetailQueryHandler(NonProfitContext context)
        {
            _context = context;
        }
        public async Task<EventDetailModel> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Events.Where(e => e.Id == request.EventId)
                                        .Select(e => new EventDetailModel
                                        {
                                            EventName = e.Name,
                                            EventTypeName = e.EventType.Name,
                                            Address1 = e.Address.Address1,
                                            Address2 = e.Address.Address2,
                                            City = e.Address.City,
                                            State = e.Address.State,
                                            Country = e.Address.Country,
                                            PostalCode = e.Address.PostalCode,
                                            StartDateTime = e.EventSchedule.StartDateTime,
                                            EndDateTime = e.EventSchedule.EndDateTime,
                                            Repeat = e.EventSchedule.Repeat
                                        })
                                        .FirstOrDefaultAsync();

            if (entity == null)
                throw new NotFoundException(nameof(Event), request.EventId);

            return entity;
        }
    }
}