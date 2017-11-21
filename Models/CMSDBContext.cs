
using System.Data.Entity;

namespace MVCTutorials9AM.Models
{
    public class CMSDBContext : DbContext
    {
        public CMSDBContext() : base("CMSConnection")
        {

        }

        public DbSet<CarMaker> CarMaker { get; set; }
        public DbSet<CarModel> CarModel { get; set; }


    }
}