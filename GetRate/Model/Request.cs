using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class Request
    {
        public Request()
        {
            //Quotations = new List<Quotation>();
            RequestTransportationTypes = new List<RequestTransportationType>();
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int? FromCargoPackageId { get; set; }
        public virtual CargoPackage FromCargoPackage { get; set; }
        public int? FromCityId { get; set; }
        public virtual City FromCity { get; set; }
        public int? FromRoutePointId { get; set; }
        public virtual RoutePoint FromRoutePoint { get; set; }

        public bool FromHandlingNeeded { get; set; }

        public int? ToCargoPackageId { get; set; }
        public virtual CargoPackage ToCargoPackage { get; set; }
        public int? ToCityId { get; set; }
        public virtual City ToCity { get; set; }
        public int? ToRoutePointId { get; set; }
        public virtual RoutePoint ToRoutePoint { get; set; }

        public bool ToHandlingNeeded { get; set; }

        public decimal CargoGW { get; set; }
        public decimal CargoVolume { get; set; }

        [NotMapped]
        public Company RequestCompany
        {
            get
            {
                return DataWorker.GetCompanyById(CompanyId);
            }
        }

        [NotMapped]
        public City RequestFromCity
        {
            get
            {
                return DataWorker.GetCityById((int)FromCityId);
            }
        }

        [NotMapped]
        public City RequestToCity
        {
            get
            {
                return DataWorker.GetCityById((int)ToCityId);
            }
        }

        [NotMapped]
        public RoutePoint RequestFromRoutePoint
        {
            get
            {
                return DataWorker.GetRoutePointById((int)FromRoutePointId);
            }
        }
        [NotMapped]
        public RoutePoint RequestToRoutePoint
        {
            get
            {
                return DataWorker.GetRoutePointById((int)ToRoutePointId);
            }
        }

        [NotMapped]
        public CargoPackage RequestFromCargoPackage
        {
            get
            {
                return DataWorker.GetCargoPackageById((int)FromCargoPackageId);
            }
        }
        [NotMapped]
        public CargoPackage RequestToCargoPackage
        {
            get
            {
                return DataWorker.GetCargoPackageById((int)ToCargoPackageId);
            }
        }
        //public virtual ICollection<Quotation> Quotations { get; set; }

        public virtual ICollection<RequestTransportationType> RequestTransportationTypes { get; set; }
    }
}