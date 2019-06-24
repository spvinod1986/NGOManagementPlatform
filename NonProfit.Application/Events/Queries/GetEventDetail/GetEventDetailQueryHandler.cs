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
            var entity = await _context.Events.Where(e => e.Id == request.Id)
                                        .Select(e => new EventDetailModel
                                        {
                                            Id = e.Id,
                                            Name = e.Name,
                                            StartDateTime = e.StartDateTime,
                                            EndDateTime = e.EndDateTime
                                        })
                                        .FirstOrDefaultAsync();

            if (entity == null)
                throw new NotFoundException(nameof(Event), request.Id);

            return entity;
        }
    }
}