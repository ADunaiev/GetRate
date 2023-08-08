using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class City
    {
        public City()
        {
            CityAddresses = new List<Address>();
        }
        public int Id { get; set; }
        public string NameENG { get; set; }
        public string NameUKR { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Address> CityAddresses { get; set; }
        [NotMapped]
        public Country CityCountry
        {
            get
            {
                return DataWorker.GetCountryById(CountryId);
            }
        }

    }
}
