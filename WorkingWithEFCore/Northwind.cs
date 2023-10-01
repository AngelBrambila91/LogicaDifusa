using Microsoft.EntityFrameworkCore;// DbContext, DbContextOptionsBuilder

namespace WorkingWithEntityFrameWorkCore;

public class Northwind : DbContext
// This class, manage the connection to the DB
{
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
}