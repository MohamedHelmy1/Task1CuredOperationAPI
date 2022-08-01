using Microsoft.EntityFrameworkCore;

namespace Task1CuredOperationAPI.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }
        public DbSet<Employee>  Employees { get; set; }
    }
}
