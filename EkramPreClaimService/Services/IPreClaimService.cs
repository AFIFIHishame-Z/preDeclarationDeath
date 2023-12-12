using EkramPreClaimService.Models;
using Microsoft.Azure.Cosmos;

namespace EkramPreClaimService.Services
{
    public interface IPreClaimService
    {
        Task<PreClaimModel> GetPreClaim(Guid preClaimId);
        Task<ItemResponse<PreClaimModel>> CreatePreClaim(PreClaimModel preClaim);

        Task<IEnumerable<PreClaimModel>> GetPreClaims();

    }
}
