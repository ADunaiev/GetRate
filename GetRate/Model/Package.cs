using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class Package
    {
        public Package() 
        { 
            CargoPackages = new List<CargoPackage>();
        }
        public int Id { get; set; } 
        public string NameENG { get; set; }
        public string NameUKR { get; set; }
        public decimal Payload { get; set; }
        public decimal PackageWeight { get; set; }

        public virtual ICollection<CargoPackage> CargoPackages { get; set; }
    }
}
