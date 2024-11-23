using System.ComponentModel.DataAnnotations;

namespace QuitQ.Models
{
    public class Seller : User
    {
        public Seller()
        {
            Products = new HashSet<Product>();
        }
        public int SellerId { get; set; }
        public string SellerPhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public string CompanyName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int PinCode { get; set; }
        public string GSTIN { get; set; } = null!;
        public string BankAccountNumber { get; set; } = null!;

        public virtual User? Users { get; set; } = null!;
        public virtual ICollection<Product>? Products { get; set; }

    }
}
