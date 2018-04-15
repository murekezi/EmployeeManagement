using EmployeeManagement.Model;

namespace EmployeeManagement.Domain
{
	/// <summary>
	/// Salary from 5000 to 7000 has 15% of tax.
	/// </summary>
	public class CalculateTaxSalaryThirdStrategy : ICalculateTaxSalaryStrategy
	{
		private const decimal maxSalary = 7000;
		private const decimal minSalary = 5000;
		private const decimal tax = 15;

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
