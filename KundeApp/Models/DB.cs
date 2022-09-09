using Microsoft.EntityFrameworkCore;

namespace KundeApp.Models
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Vare> Vare { get; set; }
        public virtual DbSet<Kunde> Kunde { get; set; }
        public virtual DbSet<Ordre> Ordre { get; set; }
        public virtual DbSet<OrdreLinje> OrdreLinje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optinsBuilder)
        {
            optinsBuilder.UseLazyLoadingProxies();
        }

        // fortett video på minutt 03:46 sekunder...
    }
}
