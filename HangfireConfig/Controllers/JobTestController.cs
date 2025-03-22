using Hangfire;
using HangfireConfig.Services;
using Microsoft.AspNetCore.Mvc;

namespace HangfireConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTestController : Controller
    {
      private readonly IJobTestService jobTestService;
      private readonly IBackgroundJobClient backgroundJobClient;
        private readonly IRecurringJobManager recurringJobManager;

        public JobTestController(IJobTestService jobTestService, IBackgroundJobClient backgroundJobClient, IRecurringJobManager recurringJobManager)
        {
            this.jobTestService = jobTestService;
            this.backgroundJobClient = backgroundJobClient;
            this.recurringJobManager = recurringJobManager;
        }

        [HttpGet("/FireAndForgetJob")]
        public IActionResult CreateFireAndForgetJob() {
            backgroundJobClient.Enqueue(() => jobTestService.FireAndForgetJob());
            return Ok();
        }

        [HttpGet("/DelayedJob")]
        public IActionResult CreateDelayedJob()
        {
            backgroundJobClient.Schedule(() => jobTestService.DelayedJob(), TimeSpan.FromSeconds(60));
            return Ok();
        }
    }
}
