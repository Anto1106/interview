using CoinDistributor.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinDistributor.Infrastructure
{
	public static class ServicesConfigurationExtension
	{
		public static IServiceCollection RegisterConfiguration(this IServiceCollection services, IConfiguration Configuration)
		{
			services.AddSingleton<IDistributorService, DistributorService>();
			services.AddSingleton(Configuration);
			return services;
		}
	}
}
