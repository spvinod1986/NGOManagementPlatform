using System;
using MediatR;

namespace NonProfit.Application.Events.Commands.CreateEvent
{
    public class CreateEventCommand : IRequest<int>
    {
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}