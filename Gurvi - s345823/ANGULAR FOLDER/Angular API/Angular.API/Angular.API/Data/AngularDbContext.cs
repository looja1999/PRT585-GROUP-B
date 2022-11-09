using Angular.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Angular.API.Data
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
    }
}
