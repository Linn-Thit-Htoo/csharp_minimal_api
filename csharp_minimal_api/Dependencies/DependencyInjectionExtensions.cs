using csharp_minimal_api.Services.BlogServices;

namespace csharp_minimal_api.Dependencies
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, WebApplicationBuilder builder)
        {
            builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            builder.Services.AddSingleton<IBlogService, BlogService>();
            builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(opt =>
            {
                opt.SerializerOptions.PropertyNamingPolicy = null;
            });

            builder.Services.AddOpenApi();

            return services;
        }
    }
}
