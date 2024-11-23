using System.ComponentModel.DataAnnotations;

namespace QuitQ.Models
{
    public class Order
    {
        public Order()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int? OrderId { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public int ItemQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? ShippingAddress { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus OrderStatus { get; set; }

        public virtual User? Users { get; set; } = null!;
        public virtual Product? Products { get; set; } = null!;
        public virtual ICollection<Payment>? Payments { get; set; }

    }
    public enum OrderStatus
    {
        Pending = 0,
        Shipped = 1,
        Delivered = 2,
        Cancelled = 3
    }
}
