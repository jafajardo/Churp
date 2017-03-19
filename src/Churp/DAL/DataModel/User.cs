using System;
using System.Collections.Generic;

namespace Churp.DAL.DataModel
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public DateTime LastActivityDate { get; set; }
        public int ApplicationId { get; set; }
        public virtual Application Application { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
