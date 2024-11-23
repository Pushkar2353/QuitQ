using QuitQ.Models;
using System.ComponentModel.DataAnnotations;

namespace QuitQ.DTOs
{
    public class CustomerDTO : UserDTO
    {
        public int? CustomerId { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string? PhoneNumber { get; set; } = null;

        [Required(ErrorMessage = "Gender is required.")]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(1000, ErrorMessage = "Address Line 1 name must not exceed 1000 characters.")]
        public string AddressLine1 { get; set; } = null!;

        [StringLength(1000, ErrorMessage = "Apartment Line 2 name must not exceed 1000 characters.")]
        public string AddressLine2 { get; set; } = null!;

        [Required(ErrorMessage = "Street is required.")]
        [StringLength(100, ErrorMessage = "Street name must not exceed 100 characters.")]
        public string Street { get; set; } = null!;

        [Required(ErrorMessage = "City is required.")]
        [StringLength(100, ErrorMessage = "City name must not exceed 100 characters.")]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "State is required.")]
        [StringLength(100, ErrorMessage = "State name must not exceed 100 characters.")]
        public string State { get; set; } = null!;

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(100, ErrorMessage = "Country name must not exceed 100 characters.")]
        public string Country { get; set; } = null!;

        [Required(ErrorMessage = "Pin Code is required.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Pin Code must be exactly 6 digits.")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "Pin Code must contain only digits.")]
        public int PinCode { get; set; }

    }
}
