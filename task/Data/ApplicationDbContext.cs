
using Microsoft.EntityFrameworkCore;
using task.Model;

namespace task.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
    
}
