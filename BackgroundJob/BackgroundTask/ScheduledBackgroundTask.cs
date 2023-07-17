using Microsoft.Extensions.Hosting;


public class ScheduledBackgroundTask : BackgroundService
{
    private readonly TimeSpan _period = TimeSpan.FromSeconds(5); // amen 5 vrk

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using PeriodicTimer timer = new PeriodicTimer(_period);

        while (!stoppingToken.IsCancellationRequested &&
               await timer.WaitForNextTickAsync(stoppingToken))
        {
            Console.WriteLine("Runing job");
        };
    }
}


