var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.HelloWorld_ConsoleApp_ApiService>("apiservice");

builder.AddProject<Projects.HelloWorld_ConsoleApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
