using System.Collections.Generic;

namespace Churp.DAL.DataModel
{
    public class NotificationType : BaseModel
    {
        public string Type { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
