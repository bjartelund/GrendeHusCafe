using Context;
using MigrationService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();


builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));

builder.AddSqlServerDbContext<CafeContext>("grendehus-cafe-db");

var host = builder.Build();
host.Run();