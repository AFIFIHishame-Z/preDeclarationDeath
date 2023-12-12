using EkramPreClaimService;

var builder = WebApplication.CreateBuilder(args);

builder.AddCustomMvc();
builder.AddCustomApplicationServices();
builder.AddCustomCosmos();
builder.AddCustomSwagger();

var app = builder.Build();

app.UseCustomSwagger();
app.UseCustomControllers();

app.Run();
