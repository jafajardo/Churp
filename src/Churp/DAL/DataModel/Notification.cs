namespace Churp.DAL.DataModel
{
    public class Notification : BaseModel
    {
        public int NotificationTypeId { get; set; }
        public int NotificationTime { get; set; }
        public int NotificationTimeUnitId { get; set; }
        public int ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual NotificationType NotificationType { get; set; }
        public virtual NotificationTimeUnit NotificationTimeUnit { get; set; }
    }
}
