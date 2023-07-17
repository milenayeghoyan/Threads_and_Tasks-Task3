using Quartz;
using Quartz.Impl;

namespace BackgroundJob.QuartzNet
{
    public class QuartzNetScheduler
    {
        public async Task ScheduleQuartzNet()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler(); // shedular i istance enq stexcum 
            await scheduler.Start(); // start enq anum 

            IJobDetail job = JobBuilder.Create<BackGroundJob>().Build();

            ITrigger trigger = TriggerBuilder.Create() //stored programs that are automatically executed or fired when some events occur on data.
                .WithDailyTimeIntervalSchedule(schd =>
                {
                    schd.WithIntervalInSeconds(20);
                    schd.OnEveryDay();
                    schd.StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(1, 27));
                })
                .Build();

            try
            {
                await scheduler.ScheduleJob(job, trigger);
                await scheduler.Shutdown();

            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}