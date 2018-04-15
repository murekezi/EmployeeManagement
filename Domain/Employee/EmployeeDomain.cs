using EmployeeManagement.Model;
using System.Collections.Generic;

namespace EmployeeManagement.Domain
{
	public sealed class EmployeeDomain : IEmployeeDomain
	{
		public Employee CalculateTaxSalary(Employee employee)
		{
			var strategies = new List<ICalculateTaxSalaryStrategy>
			{
				new CalculateTaxSalaryFirstStrategy(),
				new CalculateTaxSalarySecondStrategy(),
				new CalculateTaxSalaryThirdStrategy(),
				new CalculateTaxSalaryFourthStrategy()
			};

			foreach (var strategy in strategies)
			{
				if (strategy.IsSatisfied(employee.GrossSalary))
				{
					employee.TaxSalary = strategy.CalculateTaxSalary(employee.GrossSalary);
					break;
				}
			}

			return employee;
		}
	}
}
