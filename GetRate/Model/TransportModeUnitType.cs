using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public virtual ICollection<RoutePointTransportModeUnitType> RoutePointTransportModeUnitTypes { get; set; }
        public virtual ICollection<TransportationType> TransportationTypes { get; set; }
    }
}
