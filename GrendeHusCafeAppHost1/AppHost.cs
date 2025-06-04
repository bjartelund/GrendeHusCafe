using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("grendehus-cafe-sql-server")
    .WithLifetime(ContainerLifetime.Persistent);

var db = sql.AddDatabase("grendehus-cafe-db");

builder.AddProject<MigrationService>("GrendeHusCafeMigrationService")
    .WithReference(db)
    .WaitFor(db);

builder.AddProject<App>("GrendeHusCafeApp")
    .WithReference(db).WaitFor(db);

builder.Build().Run();