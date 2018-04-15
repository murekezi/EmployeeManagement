using EmployeeManagement.Model;

namespace EmployeeManagement.Domain
{
	/// <summary>
	/// Salary from 3000 to 5000 has 10% of tax.
	/// </summary>
	public class CalculateTaxSalarySecondStrategy : ICalculateTaxSalaryStrategy
	{
		private const decimal maxSalary = 5000;
		private const decimal minSalary = 3000;
		private const decimal tax = 10;

		public TaxSalary CalculateTaxSalary(decimal salary)
		{
			if (!IsSatisfied(salary)) { return null; }

			return new TaxSalary
			{
				MaxSalary = maxSalary,
				MinSalary = minSalary,
				NetSalary = salary - (salary / 100 * tax),
				Tax = tax
			};
		}

		public bool IsSatisfied(decimal salary)
		{
			return salary >= minSalary && salary < maxSalary;
		}
	}
}
