using System.Collections.Generic;

namespace Churp.DAL.DataModel
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ApplicationId { get; set; }
        public virtual Application Application { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
