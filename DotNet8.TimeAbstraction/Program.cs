using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<ITimeProvider, MyTimeProvider>();
builder.Services.AddTransient<DIGreeterService>();
builder.Services.AddTransient<QuickAndDirtyGreeterService>();
builder.Services.AddHostedService<Worker>();


using IHost host = builder.Build();

await host.RunAsync();
