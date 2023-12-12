using EkramPreClaimService.Models;
using EkramPreClaimService.Services;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using PreClaim.Domain;

namespace EkramPreClaimService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PreClaimController : ControllerBase
    {
        private readonly IPreClaimService preClaimService;

        public PreClaimController(IPreClaimService preClaimService)
        {
            this.preClaimService = preClaimService;
        }

        [HttpGet("get")]
        [ProducesResponseType(typeof(PreClaimModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPreClaims()
        {
            var preClaims = await preClaimService.GetPreClaims();
            return Ok(preClaims);
        }

        [HttpGet("get/{id}")]
        [ProducesResponseType(typeof(PreClaimModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPreClaim(Guid id)
        {
            var preClaim = await preClaimService.GetPreClaim(id);
            return Ok(preClaim);
        }

        [HttpPost("create")]
        [ProducesResponseType(typeof(PreClaimModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreatePreClaim([FromForm] PreClaimDto preClaimDto)
        {
            var mappedPreClaim = preClaimDto.Adapt<PreClaimModel>();
            var response = await preClaimService.CreatePreClaim(mappedPreClaim);
            return response.RequestCharge > 0 ? Ok(response.Resource) : BadRequest();
        }
    }
}
