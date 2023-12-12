using CosmosDbGenericRepository;
using EkramPreClaimService.Models;
using Microsoft.Azure.Cosmos;

namespace EkramPreClaimService.Repositories
{
    public class PreClaimRepository : GenericRepository<PreClaimModel, Guid>, IPreClaimRepository
    {
        public PreClaimRepository(CosmosClient cosmosClient, IConfiguration configuration)
            : base(
                  cosmosClient,
                  configuration["cosmosDb:DatabaseName"] ?? "",
                  configuration["cosmosDb:ContainerName"] ?? ""
                  )
        { }
    }
}
