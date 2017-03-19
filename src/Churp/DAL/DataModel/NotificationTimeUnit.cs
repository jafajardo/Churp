using System.Collections.Generic;

namespace Churp.DAL.DataModel
{
    public class NotificationTimeUnit : BaseModel
    {
        public string TimeUnit { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
