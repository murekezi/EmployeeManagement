using EmployeeManagement.Model;

namespace EmployeeManagement.Domain
{
	public interface IEmployeeDomain
	{
		Employee CalculateTaxSalary(Employee employee);
	}
}
