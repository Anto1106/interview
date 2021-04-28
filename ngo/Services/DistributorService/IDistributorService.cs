using ngo.Model;
using ngo.Services.DistributorService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngo.Services.DistributorService
{
	public interface IDistributorService
	{
		Task<Tuple<bool, List<ReciverDto>, string>> CalculateAmount(DistributorDto dto);
	}
}
