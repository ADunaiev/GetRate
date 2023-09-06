using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class RouteItemRate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int RouteItemId { get; set; }
        public virtual RouteItem RouteItem { get; set; }
        public decimal Rate { get; set; }
        public DateTime Validity { get; set; }
        [NotMapped]
        public Company RouteItemRateCompany
        {
            get
            {
                return DataWorker.GetCompanyById(CompanyId);
            }
        }
        [NotMapped]
        public RouteItem RouteItemRateRouteItem
        {
            get
            {
                return DataWorker.GetRouteItemById(RouteItemId);
            }
        }

    }
}
