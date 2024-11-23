using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace QuitQ.Models
{
    public class Payment
    {
        public int? PaymentId { get; set; }
        public int? OrderId { get; set; }
        public int? UserId { get; set; }
        public decimal? AmountToPay { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public virtual Order? Orders { get; set; } = null!;
        public virtual User? Users { get; set; } = null!;
    }
    public enum PaymentMethod
    {
        [EnumMember(Value = "Credit Card")]
        CreditCard = 1,

        [EnumMember(Value = "Debit Card")]
        DebitCard = 2,

        [EnumMember(Value = "Net Banking")]
        NetBanking = 3,

        [EnumMember(Value = "UPI")]
        UPI = 4,

        [EnumMember(Value = "Cash on Delivery")]
        CashOnDelivery = 5
    }
    public enum PaymentStatus
    {
        Pending = 0,
        Completed = 1,
        Failed = 2
    }
}
