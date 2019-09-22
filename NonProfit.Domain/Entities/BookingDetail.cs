using System;

namespace NonProfit.Domain.Entities
{
    public class BookingDetail : AuditEntity
    {
        public long Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile Userprofile { get; set; }

    }
}