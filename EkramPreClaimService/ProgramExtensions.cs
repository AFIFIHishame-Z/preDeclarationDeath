using EkramPreClaimService.Repositories;
using EkramPreClaimService.Services;
using Microsoft.Azure.Cosmos;
using System.Text.Json;

namespace EkramPreClaimService
{
    public static class ProgramExtensions
    {

        public static void AddCustomMvc(this WebApplicationBuilder builder)
        {

            builder.Services.AddControllers();
        }

        public static void AddCustomApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPreClaimService, PreClaimService>();
            builder.Services.AddScoped<IPreClaimRepository, PreClaimRepository>();
        }

        public static void AddCustomCosmos(this WebApplicationBuilder builder)
        {
            CosmosClient cosmosClient = new CosmosClient(builder.Configuration["CosmosDb:ConnectionString"]);
            builder.Services.AddSingleton(cosmosClient);
        }

        public static void AddCustomSwagger(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }

        public static void UseCustomSwagger(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
        }

        public static void UseCustomControllers(this WebApplication app)
        {
            app.UseAuthorization();
            app.MapControllers();
        }


    }

}
