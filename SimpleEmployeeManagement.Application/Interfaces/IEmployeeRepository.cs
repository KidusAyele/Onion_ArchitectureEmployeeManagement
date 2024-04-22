

using SimpleEmployeeManagement.Domain.Entities;

namespace SimpleEmployeeManagement.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task AddAsync(Employees employee);
		Task<List<Employees>>GetAllAsync();
        Task<Employees?> GetByIdAsync(int id);
        Task UpdateAsync(Employees employees);
        Task DeleteAsync(int id);

	}
}
