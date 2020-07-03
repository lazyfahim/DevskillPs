using DevskillSystem.data;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Repositories
{
    public class NotificationQueueRepository:Repository<NotificationQueue,int,FrameWorkContext>, INotificationQueueRepository
    {
        public NotificationQueueRepository(FrameWorkContext context) : base(context)
        {
        }
    }
}