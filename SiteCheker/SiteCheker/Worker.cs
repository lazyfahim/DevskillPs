using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SiteCheker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        HttpClient client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                HttpResponseMessage result =  await client.GetAsync("http://www.google.com");
                if (result.IsSuccessStatusCode)
                {
                    _logger.LogInformation($"{DateTime.Now} the web site is up with status code {result.StatusCode}");
                }
                else
                    _logger.LogWarning($" {DateTime.Now} the web site is down and status code is {result.StatusCode}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
