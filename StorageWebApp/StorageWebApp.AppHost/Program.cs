var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DBApi>("dbapi");

builder.Build().Run();
