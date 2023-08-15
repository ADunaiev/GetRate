using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class CargoPackage
    {
        public int Id { get; set; }

        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }

        public int PackageId { get; set; }
        public virtual Package Package { get; set;}

        [NotMapped]
        public string NameENG
        {
            get
            {
                return Cargo.NameENG = " in " + Package.NameENG;
            }
        }

        [NotMapped]
        public string NameUKR
        {
            get
            {
                return Cargo.NameUKR = " in " + Package.NameUKR;
            }
        }
    }
}
