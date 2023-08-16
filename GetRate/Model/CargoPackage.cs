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
