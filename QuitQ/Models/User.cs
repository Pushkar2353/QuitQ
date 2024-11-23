using System.ComponentModel.DataAnnotations;

namespace QuitQ.Models
{
    public class User
    {
        public User()
         {
             Carts = new HashSet<Cart>();
             Orders = new HashSet<Order>();
             Payments = new HashSet<Payment>();
             Reviews = new HashSet<Review>();
         }
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string UserType { get; set; } = null!;

        public virtual Customer? Customers { get; set; }
        public virtual Seller? Sellers { get; set; }
        public virtual Administrator? Administrator { get; set; }
        public virtual ICollection<Cart>? Carts { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<Payment>? Payments { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }

    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
