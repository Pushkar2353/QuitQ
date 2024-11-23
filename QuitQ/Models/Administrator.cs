using System.ComponentModel.DataAnnotations;

namespace QuitQ.Models
{
    public class Administrator : User
    {
        public int AdminId { get; set; }
        public string AdminPhoneNumber { get; set; } = null!;

        public virtual User? Users { get; set; } = null!;

    }
}
