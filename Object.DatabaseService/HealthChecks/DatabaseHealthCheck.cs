using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Object.DatabaseService.HealthChecks;

public class DatabaseHealthCheck : IHealthCheck
{
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, 
        CancellationToken cancellationToken = new CancellationToken())
    {
        bool isHealthy = await IsDatabaseConnectionOkAsync();

        return isHealthy 
            ? HealthCheckResult.Healthy("Connection is alright") 
            : HealthCheckResult.Unhealthy("Internal database error");
    }

    private Task<bool> IsDatabaseConnectionOkAsync()
    {
        return Task.FromResult(true);
    }
}