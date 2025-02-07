using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace TrendletProductsCalculater.Models
{
    public class ApplicatoinDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicatoinDbContext(DbContextOptions<ApplicatoinDbContext> options)
            : base(options)
        {
                
        }

        DbSet<Product> products { get; set; }
        DbSet<ProductType> productsType { get; set; }
        DbSet<Tax> taxes { get; set; }
        DbSet<Discount> discounts { get; set; }

    }
}
