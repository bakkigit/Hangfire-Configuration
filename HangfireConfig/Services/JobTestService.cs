namespace HangfireConfig.Services
{
    public class JobTestService : IJobTestService
    {
        private readonly ILogger _logger;

        public JobTestService(ILogger<JobTestService> logger)
        {
            _logger = logger;
        }

        public void ContinuationJob()
        {
            _logger.LogInformation("HELLO from ContinuationJob");
        }

        public void DelayedJob()
        {
            _logger.LogInformation("HELLO from DelayedJob");
        }

        public void FireAndForgetJob()
        {
            _logger.LogInformation("HELLO from FireAndForgetJob");
        }

        public void RecurringJob()
        {
            _logger.LogInformation("HELLO from RecurringJob");
        }
    }
}
