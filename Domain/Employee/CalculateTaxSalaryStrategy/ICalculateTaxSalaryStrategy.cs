using EmployeeManagement.Model;

namespace EmployeeManagement.Domain
{
	public interface ICalculateTaxSalaryStrategy
	{
		TaxSalary CalculateTaxSalary(decimal salary);

		bool IsSatisfied(decimal salary);
	}
}
