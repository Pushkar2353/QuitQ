using QuitQ.Models;
using System.ComponentModel.DataAnnotations;

namespace QuitQ.DTOs
{
    public class AdministratorDTO : UserDTO
    {
        public int? AdminId { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string AdminPhoneNumber { get; set; } = null!;

    }
}
