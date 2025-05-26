using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Model;

namespace StudentManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Student> Students => Set<Student>();
        public DbSet<Student> Students { get; set; }
    }
}
