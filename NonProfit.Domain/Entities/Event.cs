using System;
using System.Collections.Generic;

namespace NonProfit.Domain.Entities
{
    public class Event : AuditEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public EventSchedule EventSchedule { get; set; }
        public ICollection<EventFinancial> EventFinancials { get; private set; }

    }
}