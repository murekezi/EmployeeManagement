namespace EmployeeManagement.Model
{
	public class TaxSalary
	{
		public decimal? MaxSalary { get; set; }

		public decimal? MinSalary { get; set; }
		
		public decimal NetSalary { get; set; }
		
		public decimal Tax { get; set; }
	}
}
