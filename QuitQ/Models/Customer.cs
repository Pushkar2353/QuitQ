using System.ComponentModel.DataAnnotations;

namespace QuitQ.Models
{
    public class Customer : User
    {
        public int CustomerId { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public Gender? Gender { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int PinCode { get; set; }
        public virtual User? Users { get; set; } = null!;
    }
}
