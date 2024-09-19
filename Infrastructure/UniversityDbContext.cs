using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext()
        {
            
        }
        public UniversityDbContext(DbContextOptions<UniversityDbContext> dbContextOptions):base(dbContextOptions) 
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UniversityDb;TrustServerCertificate=True;Integrated Security=SSPI");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
