using Pool.Core.models;
using Pool.Core;
using Microsoft.EntityFrameworkCore;

namespace Pool.Data
{
    public class DataContext : DbContext,IDataContext
    {
        public DbSet<Guide> guides { get; set; }
        public DbSet<Swimmer> swimmers { get; set; }
        public DbSet<Activity> activities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
 
        }
  }
}
