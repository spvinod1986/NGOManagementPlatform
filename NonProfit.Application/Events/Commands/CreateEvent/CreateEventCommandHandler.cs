using System;
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
                Name = request.EventName,
                CreatedAt = DateTime.Now,
                CreatedBy = "TempUser",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "TempUser",
                EventType = new EventType
                {
                    Name = request.EventTypeName
                },
                Address = new Address
                {
                    Address1 = request.Address1,
                    Address2 = request.Address2,
                    City = request.City,
                    State = request.State,
                    Country = request.Country,
                    PostalCode = request.PostalCode
                },
                EventSchedule = new EventSchedule
                {
                    StartDateTime = request.StartDateTime,
                    EndDateTime = request.EndDateTime,
                    Repeat = request.Repeat
                }
            };

            _context.Events.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}