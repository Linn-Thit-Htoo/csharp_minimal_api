using csharp_minimal_api.Dependencies;
using csharp_minimal_api.Features.BlogEndpoints;
using csharp_minimal_api.Services.BlogServices;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDependencies(builder);

var app = builder.Build();

if (!app.Environment.IsProduction())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.MapBlogEndpoints();

app.Run();
