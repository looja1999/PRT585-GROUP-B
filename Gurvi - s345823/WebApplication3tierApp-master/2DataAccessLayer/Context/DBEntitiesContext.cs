using _2DataAccessLayer.Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context
{   

    public class DBEntitiesContext : DbContext
    {
        public DBEntitiesContext(DbContextOptions<DBEntitiesContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<GReport> GReports { get; set; }
        public DbSet<GdReport> GdReports { get; set; }


        //public DbSet<Category> Categories { get; set; }
    }

}
