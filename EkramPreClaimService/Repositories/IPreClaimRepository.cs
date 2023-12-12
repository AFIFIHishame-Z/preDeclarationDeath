using CosmosDbGenericRepository;
using EkramPreClaimService.Models;

namespace EkramPreClaimService.Repositories
{
    public interface IPreClaimRepository : IGenericRepository<PreClaimModel, Guid>
    { }
}
