var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Configuration.GetConnectionString("DefaultConnection");

var app = builder.Build();
app.MapControllers();

app.Run();
