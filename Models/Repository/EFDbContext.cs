using System.Web;
using System.Data.Entity;

namespace GameStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("conStr")
        {  }

        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}