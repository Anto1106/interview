using CoinDistributor.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinDistributor.Services
{
	public class DistributorService : IDistributorService
	{
		public async Task<string> GetAmountDistibution(BankInputDto dto)
		{
			minCoins(dto.MoneyInBank, dto.MoneyInBank.Count, dto.Amount);
			return "";
		}

		public static int minCoins(List<decimal> coins, int m, decimal V)
		{
			List<decimal> amountNeeded = new List<decimal>();
			if (V == 0) return 0;

			int res = int.MaxValue;

			for (int i = 0; i < m; i++)
			{
				if (coins[i] <= V)
				{
					int sub_res = minCoins(coins, m, V - coins[i]);

					if (sub_res != int.MaxValue && sub_res + 1 < res)
					{
						amountNeeded.Add(coins[i]);
						res = sub_res + 1;
					}
				}
			}

			return res;
		}
	}
}
