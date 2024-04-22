using Microsoft.EntityFrameworkCore;
using SimpleEmployeeManagement.Application.Interfaces;
using SimpleEmployeeManagement.Domain.Entities;
using SimpleEmployeeManagement.Infrastructure.Context;

namespace SimpleEmployeeManagement.Infrastructure.Repositories
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly EmployeeDbContext context;
        public EmployeeRepository(IDbContextFactory<EmployeeDbContext> factory)
        {
            context=factory.CreateDbContext();
            
        }

        public async Task AddAsync(Employees employee)
        {
            context.Employees.Add(employee);
            await context.SaveChangesAsync();
        }

		public async Task DeleteAsync(int id)
		{
            var employees = await GetByIdAsync(id);
            if(employees is not null)
            {
                context.Employees.Remove(employees);
                await context.SaveChangesAsync();
            }
			
		}

		public async Task<List<Employees>> GetAllAsync()
		{
            var employees = await context.Employees.ToListAsync();
            return employees;
		}

		public async Task<Employees?> GetByIdAsync(int id)
		{
            var employee = await context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            return employee;
		}

		public async Task UpdateAsync(Employees employees)
		{
				context.Entry(employees).State = EntityState.Modified;
				await context.SaveChangesAsync();
		}
	}
}
