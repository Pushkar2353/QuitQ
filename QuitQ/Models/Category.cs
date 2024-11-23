using System.ComponentModel.DataAnnotations;

namespace QuitQ.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public ICollection<Product>? Products { get; set; }
    }
}
