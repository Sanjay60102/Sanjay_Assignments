using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace APIAssignment1.Entities
{
    public class ApiAssignmentContext : DbContext
    {
        //Entity Sets
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project>  Projects { get; set; }
        public DbSet<WorksOn> worksOns { get; set; }
        //Configure ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SANJAYDELL\\SQLEXPRESS;Initial Catalog=ApiAssign;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
