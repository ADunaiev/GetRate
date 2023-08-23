using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    //public enum TransportModes { Sea, Rail, Avia, Auto }
    public class RoutePoint
    {
        public RoutePoint()
        {
            //RoutePointTransportModeUnitTypes = new List<RoutePointTransportModeUnitType>();
            //StartRoutes = new List<Route>();
            //EndPoints = new List<Route>();
            FromRoutePoints = new List<Request>();
            ToRoutePoints = new List<Request>();
            TransportationFromRoutePoints = new List<TransportationType>();
            TransportationToRoutePoints = new List<TransportationType>();
            HandlingRoutePoints = new List<Handling>();
        }
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        //public virtual IEnumerable<RoutePointTransportModeUnitType> RoutePointTransportModeUnitTypes { get; set; }

        public Company RoutePointCompany
        { 
            get
            {
                return DataWorker.GetCompanyById(CompanyId);
            }
        }

        //[InverseProperty("StartPoint")]
        //public virtual ICollection<Route> StartRoutes { get; set; }

        //[InverseProperty("EndPoint")]
        //public virtual ICollection<Route> EndPoints { get; set; }

        [InverseProperty("TransportationFromRoutePoint")]
        public virtual ICollection<TransportationType> TransportationFromRoutePoints { get; set; }

        [InverseProperty("TransportationToRoutePoint")]
        public virtual ICollection<TransportationType> TransportationToRoutePoints { get; set; }

        [InverseProperty("FromRoutePoint")]
        public virtual ICollection<Request> FromRoutePoints { get; set; }

        [InverseProperty("ToRoutePoint")]
        public virtual ICollection<Request> ToRoutePoints { get; set; }
        public virtual ICollection<Handling> HandlingRoutePoints { get; set; }
    }

    //public class Terminal : RoutePoint
    //{
    //    public Terminal()
    //    {
    //        THCRates = new List<THCRate>();
    //    }
    //    public virtual ICollection<THCRate> THCRates { get; set; }
    //}

    //public class THCRate
    //{
    //    public int Id { get; set; }
    //    public DateTime Date { get; set; }
    //    public DateTime Validity { get; set; }
    //    public Unit Unit { get; set; }
    //    public double SupplierTHCPrice { get; set; }

    //    public int TerminalId { get; set; }
    //    public virtual Terminal Terminal { get; set; }
    //}

}
