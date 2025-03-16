using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.UI.Models;

namespace EmployeeManagementSystem.UI.Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EmployeeManagement.db");
        }
    }
} 