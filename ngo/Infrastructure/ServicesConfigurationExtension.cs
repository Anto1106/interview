using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ngo.Services.DistributorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngo.Infrastructure
{
	public static class ServicesConfigurationExtension
	{
		public static IServiceCollection RegisterConfiguration(this IServiceCollection services, IConfiguration Configuration)
		{
			services.AddScoped<IDistributorService, DistributorService>();
			services.AddSingleton(Configuration);
			return services;
		}
	}
}
