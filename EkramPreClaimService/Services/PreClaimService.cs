using EkramPreClaimService.Models;
using EkramPreClaimService.Repositories;
using Microsoft.Azure.Cosmos;

namespace EkramPreClaimService.Services
{
    public class PreClaimService : IPreClaimService
    {
        private readonly IPreClaimRepository _preClaimRepository;
        public PreClaimService(IPreClaimRepository preClaimRepository)
        {
            _preClaimRepository = preClaimRepository;
        }
        public async Task<ItemResponse<PreClaimModel>> CreatePreClaim(PreClaimModel preClaim)
        {
            return await _preClaimRepository.AddAsync(preClaim);
        }

        public async Task<PreClaimModel> GetPreClaim(Guid preClaimId)
        {
            return await _preClaimRepository.GetByIdAsync(preClaimId);
        }

        public async Task<IEnumerable<PreClaimModel>> GetPreClaims()
        {
            return await _preClaimRepository.GetAllAsync();
        }
    }
}
