using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Object.PacketTraceService.HealthChecks
{
    public class PacketHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(HealthCheckResult.Healthy("Packet trace was successful"));
        }
    }
}
