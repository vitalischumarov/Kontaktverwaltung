using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class DbContactContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));

        optionsBuilder.UseMySql(
            "Server=localhost;Database=vitalitest;User=root;Password=brucelee12345;",
            serverVersion
        );
    }
}