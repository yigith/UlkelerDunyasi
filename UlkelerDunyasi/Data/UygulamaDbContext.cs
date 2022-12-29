using Microsoft.EntityFrameworkCore;

namespace UlkelerDunyasi.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }

        public DbSet<Ulke> Ulkeler => Set<Ulke>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ulke>().HasData(
                new Ulke() { Id = 1, Ad = "Türkiye" },
                new Ulke() { Id = 2, Ad = "ABD" },
                new Ulke() { Id = 3, Ad = "Kanada" },
                new Ulke() { Id = 4, Ad = "Norveç" }
                );
        }
    }
}
