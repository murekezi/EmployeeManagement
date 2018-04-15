using System;
using EmployeeManagement.Application;
using EmployeeManagement.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.CrossCutting
{
	public static class DependencyInjection
	{
		private static IServiceProvider ServiceProvider { get; set; }

		private static IServiceCollection Services { get; set; }

		public static T GetService<T>()
		{
			if (Services == null)
			{
				Services = RegisterServices();
			}

			if (ServiceProvider == null)
			{
				ServiceProvider = Services.BuildServiceProvider();
			}

			return ServiceProvider.GetService<T>();
		}

		public static IServiceCollection RegisterServices(IServiceCollection services = null)
		{
			Services = services ?? new ServiceCollection();

			Services.AddScoped<IEmployeeApplication, EmployeeApplication>();
			Services.AddScoped<IEmployeeDomain, EmployeeDomain>();

			return Services;
		}
	}
}
