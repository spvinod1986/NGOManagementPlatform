using System;

namespace NonProfit.Domain.Entities
{
    public class EventSchedule
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Repeat Repeat { get; set; }
    }
}