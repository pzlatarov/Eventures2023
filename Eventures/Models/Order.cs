namespace Eventures.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderedOn { get; set; }
        public Guid EventId { get; set; }
        public virtual Event Event { get; set; }
        public Guid CustomerId { get; set; }
        public virtual User Customer { get; set; }
        public int TicketsCount { get; set; }

    }
}
