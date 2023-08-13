using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string RoutePointNameENG
        {
            get
            {
                return routePoint.RoutePointCompany.NameENG;
            }
        }

        [NotMapped]
        public string TMUTNameENG
        {
            get
            {
                return transportModeUnitType.NameENG;
            }
        }
        public RoutePoint routePoint
        {
            get
            {
                return DataWorker.GetRoutePointById(RoutePointId);
            }
        }
        public TransportModeUnitType transportModeUnitType
        {
            get
            {
                return DataWorker.GetTransportModeUnitTypeById(TransportModeUnitTypeId);
            }
        }
    }
}
