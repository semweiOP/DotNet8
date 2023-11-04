using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Worker(IServiceProvider services) : IHostedService, IHostedLifecycleService, IDisposable
{
    private Timer? _timer = null;

    Task IHostedService.StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(DoWork, null, TimeSpan.Zero,
                  TimeSpan.FromSeconds(1));

        return Task.CompletedTask;
    }

    private void DoWork(object? state)
    {
        Console.WriteLine(
            services.GetService<QuickAndDirtyGreeterService>()!.Greet()
        );
    }

    Task IHostedService.StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);

        return Task.CompletedTask;
    }

    public Task StartedAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StartingAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
    public void Dispose()
    {
        _timer?.Dispose();
    }
}
