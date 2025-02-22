var builder = DistributedApplication.CreateBuilder(args);

var weatherForcecastApi = builder.AddProject<Projects.HR_Test_App_WeatherForecastAPI>("weatherforecastapi");
builder.AddNpmApp("AngularFrontEnd", "../HR-Test-App.AngularFrontEnd")
    .WithHttpEndpoint(env: "PORT", port: 4200)
    .WithReference(weatherForcecastApi)
    .WaitFor(weatherForcecastApi)
    .WithExternalHttpEndpoints();

builder.Build().Run();
