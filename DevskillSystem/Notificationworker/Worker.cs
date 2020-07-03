using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevSkillSystem.FrameWork.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Notificationworker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly INotificationService _notificationService;

        public Worker(ILogger<Worker> logger,INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}