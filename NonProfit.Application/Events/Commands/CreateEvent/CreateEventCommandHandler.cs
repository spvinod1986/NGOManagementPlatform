using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NonProfit.Domain.Entities;
using NonProfit.Persistence;

namespace NonProfit.Application.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, int>
    {
        private readonly NonProfitContext _context;

        public CreateEventCommandHandler(NonProfitContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var entity = new Event
            {
                Name = request.Name,
                StartDateTime = request.StartDateTime,
                EndDateTime = request.EndDateTime
            };

            _context.Events.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}