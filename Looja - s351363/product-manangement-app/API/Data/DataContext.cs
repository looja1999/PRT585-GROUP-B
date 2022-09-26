using API.Models;
using Microsoft.EntityFrameworkCore; 

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet <Category> CategoryTable { get; set; }
        public DbSet <Product> ProductTable {get; set; }
    }
}