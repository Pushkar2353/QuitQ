using QuitQ.Models;
using System.ComponentModel.DataAnnotations;

namespace QuitQ.DTOs
{
    public class PaymentDTO
    {
        public int? PaymentId { get; set; }
        public int? OrderId { get; set; }
        public int? UserId { get; set; }

        [Required(ErrorMessage = "Amount To Pay is required")]
        [DataType(DataType.Currency)]
        public decimal? AmountToPay { get; set; }

        [Required(ErrorMessage = "Payment Method is required.")]
        [EnumDataType(typeof(PaymentMethod))]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        [EnumDataType(typeof(PaymentStatus))]
        public PaymentStatus PaymentStatus { get; set; }

        [Required(ErrorMessage = "Payment Date is required.")]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; } = DateTime.Now;
    }
}
