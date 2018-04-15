using EmployeeManagement.CrossCutting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace EmployeeManagement.Web.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static void AddDependencyInjectionCustom(this IServiceCollection services)
		{
			DependencyInjection.RegisterServices(services);
		}

		public static void AddMvcCustom(this IServiceCollection services)
		{
			void Json(MvcJsonOptions json)
			{
				json.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
			}

			services.AddMvc().AddJsonOptions(Json);
		}

		public static void AddSpaStaticFilesCustom(this IServiceCollection services)
		{
			services.AddSpaStaticFiles(spa => spa.RootPath = "ClientApp/dist");
		}
	}
}
