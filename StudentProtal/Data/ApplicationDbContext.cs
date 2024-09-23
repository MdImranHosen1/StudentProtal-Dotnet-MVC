using Microsoft.EntityFrameworkCore;
using StudentProtal.Models.Entity;

namespace StudentProtal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {           
        }

        public DbSet<Student> students { get; set; }
    }
}
 