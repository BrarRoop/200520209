using _200520209.Models;
using Microsoft.EntityFrameworkCore;

namespace _200520209.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students{ get; set; }
       
    }
}
