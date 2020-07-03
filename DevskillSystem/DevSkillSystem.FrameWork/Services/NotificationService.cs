using System;
using System.Collections.Generic;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Services
{
    public class NotificationService:IDisposable, INotificationService
    {
        private readonly INotificationUnitofWork _unitofWork;

        public NotificationService(INotificationUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public ICollection<Notification> GetAllNotification(int userid)
        {
            return new List<Notification>();
        }

        public Notification Get(int id)
        {
            return new Notification();
        }

        public void Seen(int id)
        {
            
        }

        public void Dispose()
        {
            this._unitofWork.Dispose();
        }

        public IList<NotificationQueue> NotificationToProcess()
        {
            return new List<NotificationQueue>();
        }

        public void SendEmail(NotificationQueue queue)
        {
            
        }

        public void SendSMS(Notification queue)
        {
            
        }
    }
}