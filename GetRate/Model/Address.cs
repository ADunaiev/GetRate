using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class Address
    {
        public Address()
        {
           // Companies = new List<Company>();
        }
        public int Id { get; set; }
        public string StreetBuildingENG { get; set; }
        public string StreetBuildingUKR { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

        //public virtual ICollection<Company> Companies { get; set; }
        [NotMapped]
        public City AddressCity 
        { 
            get
            {
                return DataWorker.GetCityById(CityId);
            }
        }

    }
}
