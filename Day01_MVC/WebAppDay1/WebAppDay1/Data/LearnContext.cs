using Microsoft.EntityFrameworkCore;
using WebAppDay1.Models;

namespace WebAppDay1.Data
{
    public class LearnContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MAHMOUDAKL\\SQL22;Database=MVC_Learn;Integrated Security=True;TrustServerCertificate=True;");
        }

    }
}
