using DevskillSystem.data;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Repositories
{
    public class NotificationRepository:Repository<Notification,int,FrameWorkContext>, INotificationRepository
    {
        public NotificationRepository(FrameWorkContext context) : base(context)
        {
        }
    }
}