using Microsoft.EntityFrameworkCore;

namespace EmpProject.Models
{
    public class InfoContext:DbContext

    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        { }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<Compa> Compas { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Desig> Desigs { get; set; }
       
    }
}

