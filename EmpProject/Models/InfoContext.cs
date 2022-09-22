using Microsoft.EntityFrameworkCore;

namespace EmpProject.Models
{
    public class InfoContext:DbContext

    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        { }
        public DbSet<Info> Infos { get; set; }
       
    }
}

