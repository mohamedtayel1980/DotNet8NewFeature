using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace BackgroundingService
{
    public class TimedHostedService : IHostedService, IDisposable
    {
        private readonly ILogger<TimedHostedService> _logger;
        private Timer _timer;
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private DateTime _startTime = DateTime.Today.Add(new TimeSpan(16, 0, 0)); // 4:00 PM
        private DateTime _stopTime = DateTime.Today.Add(new TimeSpan(16, 31, 0)); // 4:27 PM

        public TimedHostedService(ILogger<TimedHostedService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service is starting.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private async void DoWork(object state)
        {
            var now = DateTime.Now;

            if (now >= _startTime && now < _stopTime)
            {
                _logger.LogInformation("Timed Hosted Service is working.");
            }
            else if (now >= _stopTime)
            {
                _logger.LogInformation("Timed Hosted Service stopping at stop time.");
                await StopAsync(_cts.Token);
            }
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            _cts.Cancel();

            try
            {
                await Task.Delay(5000, cancellationToken); // Optional: delay to ensure cleanup
            }
            catch (TaskCanceledException)
            {
                _logger.LogInformation("Task was canceled.");
            }

            _logger.LogInformation("Timed Hosted Service stopped.");
        }

        public void Dispose()
        {
            _timer?.Dispose();
            _cts.Dispose();
        }
    }
}
