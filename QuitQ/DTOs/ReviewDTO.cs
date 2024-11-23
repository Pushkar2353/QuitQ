using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuitQ.DTOs
{
    public class ReviewDTO
    {
        public int? ReviewId { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }

        [Required(ErrorMessage = "Product Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Review is required")]
        [Column(TypeName = "TEXT")]
        [StringLength(1000, ErrorMessage = "Review must not exceed 1000 characters.")]
        public string ReviewText { get; set; } = null!;

        [Required(ErrorMessage = "Review Date is required")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
