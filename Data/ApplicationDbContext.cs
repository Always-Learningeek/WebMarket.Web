using Microsoft.EntityFrameworkCore;
using WebMarket.Web.Models;

namespace WebMarket.Web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
    }
}
