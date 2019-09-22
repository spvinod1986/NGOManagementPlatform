using System;

namespace NonProfit.Domain.Entities
{
    public class EventFinancial : AuditEntity
    {
        public int Id { get; set; }
        public decimal Fees { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public FeeType FeeType { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}