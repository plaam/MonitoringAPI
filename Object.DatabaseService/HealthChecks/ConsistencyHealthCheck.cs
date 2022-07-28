using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Object.DatabaseService.HealthChecks
{
    public class ConsistencyHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return await IsDatabaseConsistentAsync() 
                ? HealthCheckResult.Healthy("Consistency is alright") 
                : HealthCheckResult.Unhealthy("Consistency exception");
        }

        public Task<bool> IsDatabaseConsistentAsync() 
        {
            return Task.FromResult(true);
        }
    }
}
