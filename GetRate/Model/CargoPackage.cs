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
        public CargoPackage() 
        { 
            FromCargoPackages = new List<Request>();
            ToCargoPackages = new List<Request>();
            CargoPackagesIn = new List<RouteItem>();
            CargoPackagesOut = new List<RouteItem>();
        }
        public int Id { get; set; }

        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }

        public int PackageId { get; set; }
        public virtual Package Package { get; set;}

        [InverseProperty("FromCargoPackage")]
        public virtual ICollection<Request> FromCargoPackages { get; set; }
        [InverseProperty("ToCargoPackage")]
        public virtual ICollection<Request> ToCargoPackages { get; set; }

        [InverseProperty("CargoPackageIn")]
        public virtual ICollection<RouteItem> CargoPackagesIn { get; set; }

        [InverseProperty("CargoPackageOut")]
        public virtual ICollection<RouteItem> CargoPackagesOut { get; set; }

        [NotMapped]
        public string NameENG
        {
            get
            {
                string cargoName = (DataWorker.GetCargoById(CargoId)).NameENG;
                string packageName = (DataWorker.GetPackageById(PackageId)).NameENG;

                return cargoName + " in " + packageName;
            }
        }

        [NotMapped]
        public string NameUKR
        {
            get
            {
                string cargoName = (DataWorker.GetCargoById(CargoId)).NameUKR;
                string packageName = (DataWorker.GetPackageById(PackageId)).NameUKR;

                return cargoName + " в " + packageName;
            }
        }

        [NotMapped]
        public Cargo CargoPackageCargo
        {
            get
            {
                return DataWorker.GetCargoById(CargoId);
            }
        }

        [NotMapped]
        public Package CargoPackagePackage
        {
            get
            {
                return DataWorker.GetPackageById(PackageId);
            }
        }
    }
}
