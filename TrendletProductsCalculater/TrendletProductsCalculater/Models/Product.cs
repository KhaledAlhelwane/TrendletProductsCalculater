using System.ComponentModel.DataAnnotations.Schema;

namespace TrendletProductsCalculater.Models
{
    [Table("products")]
    public class Product
    {
        public int Id { get; set; } 
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();
    }
}
