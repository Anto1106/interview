using ngo.Model;
using ngo.Services.DistributorService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngo.Services.DistributorService
{
	public class DistributorService : IDistributorService
	{
		public async Task<Tuple<bool, List<ReciverDto>, string>> CalculateAmount(DistributorDto dto)
		{
			var receivers = new List<ReciverDto>();
			var totalPercentage = 100.00;
			int usedPercentage = 0;
			for (int i = 1; i <= dto.TotalDonors; i++)
			{
				if ((totalPercentage / dto.TotalDonors) < 15)
				{
					return new Tuple<bool, List<ReciverDto>, string>(false, receivers, "“Percentage too low!");
				}
				else
				{
					var receiver = new ReciverDto();
					receiver.PersonName = "Person " + i;
					if (i == dto.TotalDonors && dto.TotalDonors % 2 != 0)
					{
						var remainigPercentage = Convert.ToInt32(Math.Round(totalPercentage / dto.TotalDonors));
						int remaingPercentage = 100 - (usedPercentage + remainigPercentage);
						receiver.Percentage = Convert.ToInt32(Math.Round(totalPercentage / dto.TotalDonors)) + remaingPercentage;
					}
					else
					{
						receiver.Percentage = Convert.ToInt32(Math.Round(totalPercentage / dto.TotalDonors));
						usedPercentage = usedPercentage + receiver.Percentage;
					}
					decimal percentage = Convert.ToDecimal(receiver.Percentage) / 100;
					receiver.Amount = dto.TotalAmount * percentage;
					receivers.Add(receiver);
				}
			}

			return new Tuple<bool, List<ReciverDto>, string>(true, receivers, "Success");
		}
	}
}
