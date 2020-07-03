using System.Collections.Generic;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Services
{
    public interface INotificationService
    {
        ICollection<Notification> GetAllNotification(int userid);
        Notification Get(int id);
        void Seen(int id);
        void Dispose();
    }
}