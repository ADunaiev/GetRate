using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Windows.Documents;

namespace GetRate.Model
{
    public class RouteItem
    {
        public RouteItem() 
        { 
            //RequestHandlings = new List<RequestHandling>();
            RouteItemRates = new List<RouteItemRate>(); 
        }
        public int Id { get; set; }
        public int? TMUT_InId { get; set; }
        public virtual TransportModeUnitType TMUT_In { get; set; }
        public int? TMUT_OutId { get; set; }
        public virtual TransportModeUnitType TMUT_Out { get; set; }

        public int? RoutePointInId { get; set; }
        public virtual RoutePoint RoutePointIn { get; set; }
        public int? RoutePointOutId { get; set; }
        public virtual RoutePoint RoutePointOut { get; set; }

        public int? CargoPackageInId { get; set; }
        public virtual CargoPackage CargoPackageIn { get; set; }
        public int? CargoPackageOutId { get; set; }
        public virtual CargoPackage CargoPackageOut { get; set; }


        [NotMapped]
        public TransportModeUnitType RouteItemTMUT_In
        {
            get
            {
                return DataWorker.GetTransportModeUnitTypeById((int)TMUT_InId);
            }
        }
        [NotMapped]
        public TransportModeUnitType RouteItemTMUT_Out
        {
            get
            {
                return DataWorker.GetTransportModeUnitTypeById((int)TMUT_OutId);
            }
        }
        [NotMapped]
        public RoutePoint RouteItemRoutePointIn
        {
            get
            {
                return DataWorker.GetRoutePointById((int)RoutePointInId);
            }
        }
        [NotMapped]
        public RoutePoint RouteItemRoutePointOut
        {
            get
            {
                return RoutePointOutId !=0 ? DataWorker.GetRoutePointById((int)RoutePointOutId):null;
            }
        }
        [NotMapped]
        public CargoPackage RouteItemCargoPackageIn
        {
            get
            {
                return DataWorker.GetCargoPackageById((int)CargoPackageInId);
            }
        }
        [NotMapped]
        public CargoPackage RouteItemCargoPackageOut
        {
            get
            {
                return DataWorker.GetCargoPackageById((int)CargoPackageOutId);
            }
        }

        [NotMapped]
        public string NameENG
        {
            get
            {
                string result = null;
                RoutePoint rpIn = DataWorker.GetRoutePointById((int)RoutePointInId);
                result += rpIn.RoutePointCompany.NameENG;
                result += " - ";
                RoutePoint rpOut = DataWorker.GetRoutePointById((int)RoutePointOutId);
                result += rpOut.RoutePointCompany.NameENG;
                result += " ";
                result += DataWorker.GetTransportModeUnitTypeById((int)TMUT_InId).NameENG;
                result += " ";
                result += DataWorker.GetTransportModeUnitTypeById((int)TMUT_OutId).NameENG;

                return result;
            }
        }

        //public virtual ICollection<RequestHandling> RequestHandlings { get; set; }
        public virtual ICollection<RouteItemRate> RouteItemRates { get; set; }

    }
}
