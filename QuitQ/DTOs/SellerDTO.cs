using QuitQ.Models;
using System.ComponentModel.DataAnnotations;

namespace QuitQ.DTOs
{
    public class SellerDTO : UserDTO
    {
        public int? SellerId { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string SellerPhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Gender is required.")]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [StringLength(100, ErrorMessage = "Company Name must not exceed 100 characters.")]
        public string CompanyName { get; set; } = null!;

        [Required(ErrorMessage = "Company Address is required.")]
        [StringLength(1000, ErrorMessage = "Address Line 1 name must not exceed 1000 characters.")]
        public string AddressLine1 { get; set; } = null!;

        [StringLength(1000, ErrorMessage = "Address Line 2 name must not exceed 1000 characters.")]
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

        [Required(ErrorMessage = "GSTIN is required.")]
        [StringLength(15, ErrorMessage = "The GSTIN must be 15 characters long.")]
        [RegularExpression("^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[A-Z0-9]{1}[Z]{1}[A-Z0-9]{1}$", ErrorMessage = "Invalid GSTIN format.")]
        public string GSTIN { get; set; } = null!;

        [Required(ErrorMessage = "The Bank Account Number is required.")]
        [StringLength(18, MinimumLength = 9, ErrorMessage = "The Bank Account Number must be between 9 and 18 digits.")]
        [RegularExpression("^[0-9]{9,18}$", ErrorMessage = "The Bank Account Number must contain only digits.")]
        public string BankAccountNumber { get; set; } = null!;
    }
}
