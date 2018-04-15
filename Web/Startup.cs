using EmployeeManagement.Web.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.Web
{
	public class Startup
	{
		public void Configure(IApplicationBuilder application, IHostingEnvironment environment)
		{
			application.UseExceptionCustom(environment);
			application.UseStaticFiles();
			application.UseSpaStaticFiles();
			application.UseMvcWithDefaultRoute();
			application.UseSpaCustom(environment);
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDependencyInjectionCustom();
			services.AddMvcCustom();
			services.AddSpaStaticFilesCustom();
		}
	}
}
