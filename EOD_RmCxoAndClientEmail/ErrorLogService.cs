using DataService.Models;

namespace EOD_ClientEmail
{
    public class ErrorLogService : IErrorLogService
    {
        private readonly IServiceProvider _serviceProvider;

        public ErrorLogService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void LogException(Exception exception)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<NeoNexusBrsContext>();

                ExceptionLog errorlog = new ExceptionLog()
                {
                   Message = exception.Message,
                   StackTrace = exception.StackTrace,
                   Timestamp = DateTime.Now
                };

                dbContext.ExceptionLogs.Add(errorlog);
                dbContext.SaveChanges();
            }
        }
    }

}
