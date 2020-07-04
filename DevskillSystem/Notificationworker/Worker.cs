using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevSkillSystem.FrameWork.Entities;
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

        private void SendEmail(NotificationQueue notificationQueue)
        {
            
        }

        private void SendSMS(NotificationQueue notificationQueue)
        {
            
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var queues = _notificationService.NotificationToProcess();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                foreach (var queue in queues)
                {
                    _notificationService.SendNotification(SendEmail,queue);
                    _notificationService.SendNotification(SendSMS,queue);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}