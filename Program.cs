var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var environmentConfig = Environment.GetEnvironmentVariable("ENV_CONFIG") ?? "Development";

app.MapGet("/environmentConfig", () =>
{
    return environmentConfig;
})
.WithName("GetEnvironmentConfig")
.WithOpenApi();

app.Run();
