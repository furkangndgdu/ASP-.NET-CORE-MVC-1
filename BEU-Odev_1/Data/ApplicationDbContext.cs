using BEU_Odev_1.Models;
using Microsoft.EntityFrameworkCore;

namespace BEU_Odev_1.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
