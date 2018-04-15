using EmployeeManagement.Model;

namespace EmployeeManagement.Application
{
	public interface IEmployeeApplication
	{
		Employee CalculateTaxSalary(Employee employee);
	}
}
