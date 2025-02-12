using Microsoft.EntityFrameworkCore;
using Web_Intro.Entities;

namespace Web_Intro.Context;
                              
public class EcommerceDbContext:DbContext
{

    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options):base(options)
    {
        
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Category> Categories { get; set; }
}
