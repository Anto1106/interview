using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinDistributor.Services;
using CoinDistributor.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoinDistributor.Controllers
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


        public async Task<IActionResult> Get([FromBody]BankInputDto distributorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(distributorDto);
            }
            return Ok(await _distributorService.GetAmountDistibution(distributorDto));
        }
    }
}