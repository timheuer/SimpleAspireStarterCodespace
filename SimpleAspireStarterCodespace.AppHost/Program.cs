var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.SimpleAspireStarterCodespace_ApiService>("apiservice");

builder.AddProject<Projects.SimpleAspireStarterCodespace_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
