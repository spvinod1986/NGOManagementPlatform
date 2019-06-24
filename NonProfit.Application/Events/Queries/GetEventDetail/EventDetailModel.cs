using System;

namespace NonProfit.Application.Events.Queries.GetEventDetail
{
    public class EventDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}