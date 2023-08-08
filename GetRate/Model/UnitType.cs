using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class UnitType
    {
        public UnitType()
        {
            RoutePoints = new List<RoutePoint>();
            //Routes = new List<Route>();
        }
        public int Id { get; set; }
        public string NameENG { get; set; }
        public string NameUKR { get; set; }
        public double MaximumGrossWeight { get; set; }

        public virtual ICollection<RoutePoint> RoutePoints { get; set; }

        //public virtual ICollection<Route> Routes { get; set; }
    }
}
