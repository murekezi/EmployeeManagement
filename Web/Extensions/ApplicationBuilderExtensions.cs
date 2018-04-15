using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices;
using Microsoft.AspNetCore.SpaServices.AngularCli;

namespace EmployeeManagement.Web.Extensions
{
	public static class ApplicationBuilderExtensions
	{
		public static void UseExceptionCustom(this IApplicationBuilder application, IHostingEnvironment environment)
		{
			application.UseDeveloperExceptionPage();
		}

		public static void UseSpaCustom(this IApplicationBuilder application, IHostingEnvironment environment)
		{
			void Spa(ISpaBuilder spa)
			{
				spa.Options.SourcePath = "ClientApp";

				if (environment.IsDevelopment())
				{
					spa.UseAngularCliServer("development");
				}
			}

			application.UseSpa(Spa);
		}
	}
}
