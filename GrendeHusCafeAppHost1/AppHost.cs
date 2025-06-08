using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddAzureSqlServer("grendehus-cafe-sql-server");

var db = sql.AddDatabase("grendehus-cafe-db");

builder.AddProject<MigrationService>("grendehus-cafe-migrations")
    .WithReference(db)
    .WaitFor(db);

builder.AddProject<App>("grendehus-cafe-app")
    .WithReference(db).WaitFor(db).WithExternalHttpEndpoints();

builder.Build()
    .Run();