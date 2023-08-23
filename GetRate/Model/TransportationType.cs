using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class TransportationType
    {
        public TransportationType() 
        { 
            RequestTransportationTypes = new List<RequestTransportationType>();    
        }
        public int Id { get; set; }
        public int TransportModeUnitTypeId { get; set; }
        public virtual TransportModeUnitType TransportModeUnitType { get; set; }
        public int? FromRoutePointId { get; set; }
        public virtual RoutePoint TransportationFromRoutePoint { get; set; }
        public int? ToRoutePointId { get; set; }
        public virtual RoutePoint TransportationToRoutePoint { get;set; }

        [NotMapped]
        public TransportModeUnitType TT_TMUT
        {
            get
            {
                return DataWorker.GetTransportModeUnitTypeById(TransportModeUnitTypeId);
            }
        }
        [NotMapped]
        public RoutePoint TT_FromRoutePoint
        {
            get
            {
                return DataWorker.GetRoutePointById((int)FromRoutePointId);
            }
        }
        [NotMapped]
        public RoutePoint TT_ToRoutePoint
        {
            get
            {
                return DataWorker.GetRoutePointById((int)ToRoutePointId);
            }
        }
        public virtual ICollection<RequestTransportationType> RequestTransportationTypes { get; set; }
    }
}
