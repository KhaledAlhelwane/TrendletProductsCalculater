using System.ComponentModel.DataAnnotations.Schema;

namespace TrendletProductsCalculater.Models
{
    [Table("productstype")]
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AddedPrice { get; set; }
    }
}
