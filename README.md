# Hangfire Demo Application 🚀

This is a simple **ASP.NET Core** application demonstrating the use of **Hangfire** for background job processing. Hangfire allows scheduling and executing jobs asynchronously with ease.

## Features 🎯
- ✅ **Fire-and-forget jobs** – Execute tasks immediately in the background.
- ✅ **Delayed jobs** – Schedule jobs to run after a set time.
- ✅ **Recurring jobs** – Run jobs at predefined intervals.
- ✅ **Continuation jobs** – Chain jobs to execute sequentially.
- ✅ **Hangfire Dashboard** – Monitor job execution through an interactive UI.

## Technologies Used 🛠️
- **ASP.NET Core**
- **Hangfire**
- **SQL Server (for Hangfire storage)**

**Access the Hangfire Dashboard**:
   Open your browser and go to:  
   **[http://localhost:5000/hangfire](http://localhost:5000/hangfire)**

## API Endpoints 📌
| Endpoint | Description |
|----------|-------------|
| `GET /FireAndForgetJob` | Triggers an immediate background job |
| `GET /DelayedJob` | Runs a job after a 60-second delay |
| `GET /RecurringJob` | Sets up a recurring job |

## How Hangfire Works ⚙️
1. **Fire-and-forget job** (executes immediately):
   ```csharp
   backgroundJobClient.Enqueue(() => jobTestService.FireAndForgetJob());
   ```

2. **Delayed job** (runs after a set delay):
   ```csharp
   backgroundJobClient.Schedule(() => jobTestService.DelayedJob(), TimeSpan.FromMinutes(5));
   ```

3. **Recurring job** (executes at intervals):
   ```csharp
   recurringJobManager.AddOrUpdate("my-recurring-job", () => jobTestService.RecurringJob(), Cron.Daily);
   ```

4. **Continuation job** (executes after another job finishes):
   ```csharp
   var parentJobId = backgroundJobClient.Enqueue(() => jobTestService.FirstJob());
   backgroundJobClient.ContinueWith(parentJobId, () => jobTestService.SecondJob());
   ```

## Why Use Hangfire? 🤔
- **Simple integration** – Just install and configure.
- **Persistence** – Jobs are stored and survive application restarts.
- **Scalability** – Can run jobs in distributed environments.
- **Automatic retries** – Failed jobs are automatically retried.
- **Dashboard** – View, monitor, and manage jobs in a web UI.

## Contribution Guidelines 🤝
Feel free to contribute by submitting issues, feature requests, or pull requests! 🚀

Happy coding! 🚀
