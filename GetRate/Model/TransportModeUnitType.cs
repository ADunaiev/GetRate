using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class TransportModeUnitType
    {
        public TransportModeUnitType() 
        {
            RoutePointTransportModeUnitTypes = new ObservableCollection<RoutePointTransportModeUnitType>();
            TransportationTypes = new ObservableCollection<TransportationType>();
        }
        public int Id { get; set; }
        public int TransportModeId { get; set; }
        public virtual TransportMode TransportMode { get; set; }
        public int UnitTypeId { get; set; }
        public virtual UnitType UnitType { get; set; }

        [NotMapped]
        public string NameENG
        {
            get
            {
                return TMUTMode.NameENG + " by " + TMUTType.NameENG;
            }
        }
        [NotMapped]
        public string NameUKR
        {
            get
            {
                return TMUTMode.NameUKR + " " + TMUTType.NameUKR;
            }
        }
        [NotMapped]
        public string TMUTModeNameENG
        {
            get
            {
                return TMUTMode.NameENG;
            }
        }
        [NotMapped]
        public string TMUTTypeNameENG
        {
            get
            {
                return TMUTType.NameENG;
            }
        }
        public TransportMode TMUTMode
        {
            get
            {
                return DataWorker.GetTransportModeById(TransportModeId);
            }
        }

        public UnitType TMUTType
        {
            get
            {
                return DataWorker.GetUnitTypeById(UnitTypeId);
            }
        }

        public virtual ICollection<RoutePointTransportModeUnitType> RoutePointTransportModeUnitTypes { get; set; }
        public virtual ICollection<TransportationType> TransportationTypes { get; set; }
    }
}
