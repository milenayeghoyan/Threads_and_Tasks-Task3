namespace BackgroundJob.QuartzNet
{
    public class WorkerClass
    {
        public async Task DomSomeAsyncWork()
        {
            Thread.Sleep(1000);
        }
    }
}
