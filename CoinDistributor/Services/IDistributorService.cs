using CoinDistributor.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinDistributor.Services
{
	public interface IDistributorService
	{
		Task<string> GetAmountDistibution(BankInputDto dto); 
	}
}
