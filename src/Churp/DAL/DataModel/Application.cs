using System.Collections.Generic;

namespace Churp.DAL.DataModel
{
    public class Application : BaseModel
    {
        public string ApplicationName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
