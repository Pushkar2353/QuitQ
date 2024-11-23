using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuitQ.Models
{
    public class Review
    {
        public int? ReviewId { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; } = null!;
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        public virtual Product? Products { get; set; } = null!;
        public virtual User? Users { get; set; } = null!;
    }
}
