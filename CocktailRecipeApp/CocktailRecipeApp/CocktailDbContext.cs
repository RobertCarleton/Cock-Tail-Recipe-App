using Microsoft.EntityFrameworkCore;

namespace CocktailRecipeApp
{
    public class CocktailDbContext : DbContext
    {
        // Define a DbSet for Cocktails
        public DbSet<Cocktail> Cocktails { get; set; }

        // Constructor accepting options for dependency injection
        public CocktailDbContext(DbContextOptions<CocktailDbContext> options) : base(options)
        { }

        // Default parameterless constructor (useful for testing or in-memory databases)
        public CocktailDbContext()
        { }

        // Configure the database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Replace with your SQL Server connection string
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CocktailRecipesDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        // Customize model creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Cocktail entity
            modelBuilder.Entity<Cocktail>(static entity =>
            {
                entity.HasKey(c => c.CocktailID); // Set primary key

                entity.Property(c => c.CocktailName)
                      .IsRequired()
                      .HasMaxLength(100); // Set required and max length for the name

                entity.Property(c => c.CocktailDescription)
                      .HasMaxLength(500); // Optional max length for description

                entity.Property(c => c.Ingredient)
                      .HasMaxLength(300); // Optional max length for ingredients

                entity.Property(c => c.Instructions)
                      .HasMaxLength(500); // Optional max length for instructions

                DateTime dt = new DateTime(2025, 1, 15);
                entity.Property(c => c.DateAdded)
                      .HasDefaultValue(dt); // Sets a fixed default value
                    //.HasDefaultValueSql("GETDATE()"); // Default value for DateAdded (SQL Server function)

                entity.Property(c => c.ImagePath)
                      .HasMaxLength(200); // Path to image with max length

                entity.Property(c => c.Rating)
                      .HasDefaultValue(0); // Default rating value
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
