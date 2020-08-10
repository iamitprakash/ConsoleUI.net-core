using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

//DI
//Logging
//Settings
namespace CosoleUICore
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _log;
        private readonly IConfiguration _config;
        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("Loop"); i++)
            {
                
                _log.LogInformation("Run number {runnumber}", i);
            }
        }
    }
}
