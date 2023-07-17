using Quartz;

namespace BackgroundJob.QuartzNet
{
    public class BackGroundJob : IJob
    {
        private WorkerClass workerClass;

        public BackGroundJob(WorkerClass workerClass)
        {
            this.workerClass = workerClass;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            int i = 10;
            while (i != 0)
            {
                Console.WriteLine($"Job is tirgered : {i} time.");
                await workerClass.DomSomeAsyncWork();
                i--;
            }
        }
    }
}