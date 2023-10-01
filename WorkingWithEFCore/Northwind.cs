using Microsoft.EntityFrameworkCore;// DbContext, DbContextOptionsBuilder

namespace WorkingWithEntityFrameWorkCore;

public class Northwind : DbContext
// This class, manage the connection to the DB
{
    // these properties map tables in the DB
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(Environment.CurrentDirectory,
        "NorthwindDB.db");
        string connection = $"Filename={path}";
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"Connection: {connection}");
        optionsBuilder.UseSqlite(connection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API
        // Limit the lenght of Category Name
        modelBuilder.Entity<Category>()
        .Property(category => category.CategoryName)
        .IsRequired() // NOT NULL
        .HasMaxLength(20);

        // Add Fluent API for Cost on Product
        if((Database.ProviderName?.Contains("Sqlite")) ?? false)
        {
            modelBuilder.Entity<Product>()
            .Property(product => product.Cost)
            .HasConversion<double>();
        }
    }
}