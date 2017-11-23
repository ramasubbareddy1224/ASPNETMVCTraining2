
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCTutorials9AM.Models
{
    public class CMSDBContext : DbContext
    {
        public CMSDBContext() : base("CMSConnection")
        {
            Database.SetInitializer<CMSDBContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<CarMaker> CarMaker { get; set; }
        public DbSet<CarModel> CarModel { get; set; }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }


    }
}