using EternaTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaTask.DataAccessLayer
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<PricingService> PricingServices { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Page_Service> Page_Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }








    }
}
