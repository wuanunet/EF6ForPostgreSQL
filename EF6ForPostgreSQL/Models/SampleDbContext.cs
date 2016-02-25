using System.Data.Entity;

namespace EF6ForPostgreSQL.Models
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext()
            : base("name=SampleDbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
    }
}