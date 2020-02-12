using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SpeedTestFunctionApp
{
    public static class SpeedTest
    {
        [FunctionName("SpeedTest")]
        public static void Run([ServiceBusTrigger("run-speedtest", "speedtest-logger-subscription", Connection = "ServiceBusConnectionString")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
