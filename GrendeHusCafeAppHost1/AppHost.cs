using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddConnectionString("grendehus-cafe-sql-server");


builder.AddProject<MigrationService>("grendehus-cafe-migrations")
    .WithReference(db);

builder.AddProject<App>("grendehus-cafe-app")
    .WithReference(db).WithExternalHttpEndpoints();

builder.Build()
    .Run();