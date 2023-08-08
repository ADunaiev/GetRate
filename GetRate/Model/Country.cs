using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class Country
    {
        public Country()
        {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string NameENG { get; set; }
        public string NameUKR { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
