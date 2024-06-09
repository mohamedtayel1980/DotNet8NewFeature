namespace BackgroundingService
{
    public class TimedBackgroundService : BackgroundService
    {
        private readonly ILogger<TimedBackgroundService> _logger;
        private readonly DateTime _startTime = DateTime.Today.Add(new TimeSpan(16, 0, 0)); // 4:00 PM
        private readonly DateTime _stopTime = DateTime.Today.Add(new TimeSpan(16, 19, 0)); // 4:19 PM

        public TimedBackgroundService(ILogger<TimedBackgroundService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Background Service running.");

            while (!stoppingToken.IsCancellationRequested)
            {
                var now = DateTime.Now;

                if (now >= _startTime && now < _stopTime)
                {
                    _logger.LogInformation("Timed Background Service is working.");
                    // Perform your periodic task here
                }
                else if (now >= _stopTime)
                {
                    _logger.LogInformation("Timed Background Service stopping at stop time.");
                    // Stop the service by cancelling the token
                    stoppingToken.ThrowIfCancellationRequested();
                }

                try
                {
                    await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
                }
                catch (TaskCanceledException)
                {
                    // Handle the task cancellation if needed
                    _logger.LogInformation("Task was canceled.");
                }
            }

            _logger.LogInformation("Timed Background Service is stopping.");
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is stopping.");

            await base.StopAsync(cancellationToken);

            _logger.LogInformation("Timed Background Service stopped.");
        }
    }
}
