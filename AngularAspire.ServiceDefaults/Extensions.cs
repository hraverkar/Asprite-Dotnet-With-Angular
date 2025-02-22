using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ServiceDiscovery;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;
namespace AngularAspire.ServiceDefaults
{
    public static class Extensions
    {
        public static TBuilder AddServiceDefaults<TBuilder>(this TBuilder builder) where TBuilder : IHostApplicationBuilder
        {
            builder.ConfigureOpenTelemetry();
            builder.AddDefaultHealthChecks();
            builder.Services.AddServiceDiscovery();
            builder.Services.ConfigureHttpClientDefaults( http =>
            {
                http.AddStandardResilienceHandler();
                http.AddServiceDiscovery();
            });
        }

    }
}
