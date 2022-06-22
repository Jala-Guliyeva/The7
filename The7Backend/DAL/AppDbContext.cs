using Microsoft.EntityFrameworkCore;
using The7Backend.Models;

namespace The7Backend.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Service>Services { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Team>Teams { get; set; }
    }
}
