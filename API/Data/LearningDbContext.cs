using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class LearningDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Box> Boxs { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Deck> Decks { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Topic> Topics { get; set; }
    }
}
