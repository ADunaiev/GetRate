using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class Handling
    {
        public Handling() 
        { 
            //RequestHandlings = new List<RequestHandling>();
        }
        public int Id { get; set; }
        public int? TMUT_InId { get; set; }
        public virtual TransportModeUnitType TMUT_In { get; set; }

        public int RoutePointId { get; set; }
        public virtual RoutePoint RoutePoint { get; set; }
        public int? TMUT_OutId{ get; set; }
        public virtual TransportModeUnitType TMUT_Out { get; set; }

        [NotMapped]
        public TransportModeUnitType HandlingTMUT_In
        {
            get
            {
                return DataWorker.GetTransportModeUnitTypeById((int)TMUT_InId);
            }
        }
        [NotMapped]
        public TransportModeUnitType HandlingTMUT_Out
        {
            get
            {
                return DataWorker.GetTransportModeUnitTypeById((int)TMUT_OutId);
            }
        }
        [NotMapped]
        public RoutePoint HandlingRoutePoint
        {
            get
            {
                return DataWorker.GetRoutePointById(RoutePointId);
            }
        }

        //public virtual ICollection<RequestHandling> RequestHandlings { get; set; }

    }
}
