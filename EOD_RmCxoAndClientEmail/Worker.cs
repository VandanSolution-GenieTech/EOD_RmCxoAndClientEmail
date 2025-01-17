using EOD_ClientEmail;
using Microsoft.Extensions.Configuration;

namespace EOD_RmCxoAndClientEmail
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;
        private readonly IErrorLogService _errorLogService;
        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider, IConfiguration configuration, IErrorLogService errorLogService)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
            _configuration = configuration;
            _errorLogService = errorLogService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
               
                    List<TimeSpan> _executionTimes = _configuration.GetSection("ExecutionSettings:ExecutionTimes").Get<List<string>>().Select(TimeSpan.Parse).ToList();
                   TimeSpan timeNow = DateTime.Now.TimeOfDay;

                    if(_executionTimes.Any(x => x.Hours == timeNow.Hours && x.Minutes == timeNow.Minutes))
                    {
                        _logger.LogInformation("Executing service task at: {time}", timeNow);

                        using (var scope = _serviceProvider.CreateScope())
                        {
                            try
                            {
                                var bankerService = scope.ServiceProvider.GetRequiredService<IEODClientEmailservice>();
                                await bankerService.GetOrderHistoryForClient(false);
                                //await bankerService.GetOrderHistory();
                                await bankerService.GetOrderHistoryForClient(true);
                            }
                            catch (Exception ex)
                            {
                                _errorLogService.LogException(ex);
                            }
                        }

                        _logger.LogInformation("Task executed successfully at: {time}", DateTimeOffset.Now);

                       
                        await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                    }

                   
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
                }
                catch (Exception ex)
                {
                    _errorLogService.LogException(ex);
                }
            }
        }
    }
}
