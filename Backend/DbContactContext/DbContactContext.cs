using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.DbContactContext;

public class DbContactContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
//die gesamte Konfiguaration wurde in der Program.cs gemacht.
    public DbContactContext(DbContextOptions<DbContactContext> options) : base(options)
    {
    }
}