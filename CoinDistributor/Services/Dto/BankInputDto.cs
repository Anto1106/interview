using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinDistributor.Services.Dto
{
	public class BankInputDto
	{
		public BankInputDto()
		{
			MoneyInBank = new List<decimal>();
		}

		public decimal Amount { get; set; }
		
		public List<decimal> MoneyInBank { get; set; }
	}
}
