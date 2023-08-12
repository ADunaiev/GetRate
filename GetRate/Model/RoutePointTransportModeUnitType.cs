using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class RoutePointTransportModeUnitType
    {
        public int Id { get; set; }
        public int RoutePointId { get; set; }
        public virtual RoutePoint RoutePoint { get; set; }

        public int TransportModeUnitTypeId { get; set; }
        public virtual TransportModeUnitType TransportModeUnitType { get; set; }
    }
}
