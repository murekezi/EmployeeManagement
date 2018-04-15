using EmployeeManagement.Application;
using EmployeeManagement.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Web.Controllers
{
	public class EmployeeServiceController : Controller
	{
		public EmployeeServiceController(IEmployeeApplication employeeApplication)
		{
			EmployeeApplication = employeeApplication;
		}

		IEmployeeApplication EmployeeApplication { get; }

		[AllowAnonymous]
		[HttpPost]
		public IActionResult CalculateTaxSalary([FromBody]Employee employee)
		{
			return Json(EmployeeApplication.CalculateTaxSalary(employee));
		}
	}
}
