using System.Web;
using System.Data.Entity;

namespace GameStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\КахаровЖ\Desktop\GameStore\App_Data\MyDB.mdf;Integrated Security=True;Connect Timeout=30")
        {  }

        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}