using Microsoft.EntityFrameworkCore;
using GpsApi.Models;

namespace GpsApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Ubicacion> Ubicaciones { get; set; }
    }
}
