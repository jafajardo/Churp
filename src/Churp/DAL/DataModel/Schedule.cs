using System;
using System.Collections.Generic;

namespace Churp.DAL.DataModel
{
    public class Schedule : BaseModel
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
