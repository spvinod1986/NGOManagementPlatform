namespace NonProfit.Domain.Entities
{
    public class UserProfile : AuditEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}