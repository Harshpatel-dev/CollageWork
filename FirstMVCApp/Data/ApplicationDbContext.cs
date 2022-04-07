using FirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;
namespace FirstMVCApp.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
    }
}
