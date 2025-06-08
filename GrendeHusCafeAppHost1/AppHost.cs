using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddAzureSqlServer("grendehus-cafe-sql-server").AddDatabase("grendehus-cafe-db");

builder.AddProject<MigrationService>("grendehus-cafe-migrations")
    .WithReference(db);

builder.AddProject<App>("grendehus-cafe-app")
    .WithReference(db).WithExternalHttpEndpoints();

builder.Build()
    .Run();