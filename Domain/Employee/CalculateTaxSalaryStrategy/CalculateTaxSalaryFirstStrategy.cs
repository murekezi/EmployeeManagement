using EmployeeManagement.Model;

namespace EmployeeManagement.Domain
{
	/// <summary>
	/// Salary below 3000 is exempt from tax.
	/// </summary>
	public class CalculateTaxSalaryFirstStrategy : ICalculateTaxSalaryStrategy
	{
		private const decimal maxSalary = 3000;
		private const decimal tax = 0;

		public TaxSalary CalculateTaxSalary(decimal salary)
		{
			if (!IsSatisfied(salary)) { return null; }

			return new TaxSalary
			{
				MaxSalary = maxSalary,
				Tax = tax,
				NetSalary = salary
			};
		}

		public bool IsSatisfied(decimal salary)
		{
			return salary < maxSalary;
		}
	}
}
