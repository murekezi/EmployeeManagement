namespace EmployeeManagement.Model
{
	public class Employee
	{
		public string Email { get; set; }
		
		public decimal GrossSalary { get; set; }
		
		public string Name { get; set; }
		
		public TaxSalary TaxSalary { get; set; }
	}
}
