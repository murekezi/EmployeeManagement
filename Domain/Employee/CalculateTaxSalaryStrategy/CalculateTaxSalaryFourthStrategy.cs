using EmployeeManagement.Model;

namespace EmployeeManagement.Domain
{
	/// <summary>
	/// Salary above 7000 has 25% tax.
	/// </summary>
	public class CalculateTaxSalaryFourthStrategy : ICalculateTaxSalaryStrategy
	{
		private const decimal minSalary = 7000;
		private const decimal tax = 25;

		public TaxSalary CalculateTaxSalary(decimal salary)
		{
			if (!IsSatisfied(salary)) { return null; }

			return new TaxSalary
			{
				MinSalary = minSalary,
				NetSalary = salary - (salary / 100 * tax),
				Tax = tax
			};
		}

		public bool IsSatisfied(decimal salary)
		{
			return salary >= minSalary;
		}
	}
}
