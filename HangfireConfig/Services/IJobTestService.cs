﻿namespace HangfireConfig.Services
{
    public interface IJobTestService
    {
        void FireAndForgetJob();
        void RecurringJob();
        void DelayedJob();
        void ContinuationJob();
    }
}
