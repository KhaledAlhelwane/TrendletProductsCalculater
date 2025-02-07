using System.ComponentModel.DataAnnotations.Schema;

namespace TrendletProductsCalculater.Models
{
    [Table("taxes")]
    public class Tax
    {
        public int Id { get; set; } 
        public int Name { get; set; }
        public double Value { get; set; }
    }
}
