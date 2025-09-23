using Microsoft.EntityFrameworkCore;
using Backend.DbContactContext;

var builder = WebApplication.CreateBuilder(args);

//ueber diesen Weg, kann ich die Konfiguration meiner DbContext auslagern in die Main.
builder.Services.AddDbContext<DbContactContext>(options =>
{
    //der Name des ConnectionStrings ist in der launchSettings gespeichert und ueber der Begriff
    //DefaultConntion kommt in beiden vor. Damit wird es zugeordnet.
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));
    options.UseMySql(connectionString, serverVersion);
});

builder.Services.AddControllers();
builder.Configuration.GetConnectionString("DefaultConnection");

var app = builder.Build();
app.MapControllers();

app.Run();
