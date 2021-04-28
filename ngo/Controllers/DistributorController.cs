using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ngo.Model;
using ngo.Services.DistributorService;

namespace ngo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DistributorController : ControllerBase
	{
		private readonly IDistributorService _distributorService;
		public DistributorController(IDistributorService distributorService)
		{
			_distributorService = distributorService;
		}

		public async Task<IActionResult> Get([FromBody]DistributorDto distributorDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(distributorDto);
			}
			var data = await _distributorService.CalculateAmount(distributorDto);
			if (data.Item1)
				return Ok(data.Item2);
			else
				return BadRequest(new { message = data.Item3 });
		}
	}
}