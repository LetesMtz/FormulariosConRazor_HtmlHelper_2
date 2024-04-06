using Microsoft.EntityFrameworkCore;

namespace FormulariosConRazor_HtmlHelper_2.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<marcas> marcas { get; set; }
        public DbSet<equipos> equipos { get; set; }
    }
}
