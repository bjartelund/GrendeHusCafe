using Projects;

var builder = DistributedApplication.CreateBuilder(args);

#if !DEBUG
var sql = builder.AddAzureSqlServer("grendehus-cafe-sql-server");
#else
var sql = builder.AddSqlServer("grendehus-cafe-sql-server").WithLifetime(ContainerLifetime.Persistent);
#endif

var db = sql.AddDatabase("grendehus-cafe-db");

builder.AddProject<MigrationService>("grendehus-cafe-migrations")
    .WithReference(db);

builder.AddProject<App>("grendehus-cafe-app")
    .WithReference(db).WithExternalHttpEndpoints();

builder.Build()
    .Run();