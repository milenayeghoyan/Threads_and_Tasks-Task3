// See https://aka.ms/new-console-template for more information

using BackgroundJob.BackgroundTask;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
          .ConfigureHostConfiguration(configHost => {
          })
          .ConfigureServices((hostContext, services) => {
              services.AddHostedService<ScheduledBackgroundTask>();
          })
         .UseConsoleLifetime()
         .Build();

//run the host
host.Run();


//QuartzNetScheduler qs = new QuartzNetScheduler();
//await qs.ScheduleQuartzNet();

Console.ReadLine();
