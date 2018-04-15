using EmployeeManagement.Domain;
using EmployeeManagement.Model;

namespace EmployeeManagement.Application
{
	public sealed class EmployeeApplication : IEmployeeApplication
	{
		public EmployeeApplication(IEmployeeDomain employeeDomain)
		{
			EmployeeDomain = employeeDomain;
		}

		private IEmployeeDomain EmployeeDomain { get; }

		public Employee CalculateTaxSalary(Employee employee)
		{
			return EmployeeDomain.CalculateTaxSalary(employee);
		}
	}
}
