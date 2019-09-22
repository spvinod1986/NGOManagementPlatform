using System;
using MediatR;
using NonProfit.Domain.Entities;

namespace NonProfit.Application.Events.Commands.CreateEvent
{
    public class CreateEventCommand : IRequest<int>
    {
        public string EventName { get; set; }
        public string EventTypeName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Repeat Repeat { get; set; }
    }
}