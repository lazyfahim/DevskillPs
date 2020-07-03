using System;
using DevskillSystem.data;

namespace DevSkillSystem.FrameWork.Entities
{
    public class NotificationQueue:IEntity<int>
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
        public int FailCount { get; set; } = 0;
        public QueueStatus Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public enum QueueStatus
    {
        NEW,
        PROCESSING,
        PROCESSED,
        FAILED
    }
}