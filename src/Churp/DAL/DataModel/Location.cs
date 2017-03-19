using System.Collections.Generic;

namespace Churp.DAL.DataModel
{
    public class Location : BaseModel
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
