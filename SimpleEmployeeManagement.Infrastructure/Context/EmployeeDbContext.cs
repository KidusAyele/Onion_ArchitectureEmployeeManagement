
using Microsoft.EntityFrameworkCore;
using SimpleEmployeeManagement.Domain.Entities;

namespace SimpleEmployeeManagement.Infrastructure.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employees> Employees { get; set; }
    }
}
