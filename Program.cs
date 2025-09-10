using GpsApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// opcional: log minimal, swagger, etc.
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36))
    )
);

// Fuerza a Kestrel a escuchar en el puerto que Render provee
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
builder.WebHost.UseUrls("http://0.0.0.0:" + port);

var app = builder.Build();
app.UseRouting();
app.MapControllers();
app.Run();
