using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public enum CompanyType { Customer, Supplier, Carrier, Terminal }
    public class Company
    {
        public Company()
        {
            Requests = new List<Request>();
            //Carriers = new List<RouteSupplierRate>();
            RoutePoints = new List<RoutePoint>();
            RouteItemRates = new List<RouteItemRate>(); 
        }
        public int Id { get; set; }
        public string NameENG { get; set; }
        public string NameUKR { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public CompanyType companyType { get; set; }

        public Address CompanyAddress
        {
            get
            {
                return DataWorker.GetAddressById(AddressId);
            }
        }

        public virtual ICollection<Request> Requests { get; set; }
        //public virtual ICollection<RouteSupplierRate> Carriers { get; set; }
        public virtual ICollection<RoutePoint> RoutePoints { get; set; }
        public virtual ICollection<RouteItemRate> RouteItemRates { get; set; }
    }
}
