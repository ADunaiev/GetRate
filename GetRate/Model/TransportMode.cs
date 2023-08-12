using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class TransportMode
    {
        public TransportMode() 
        { 
            TransportModeUnitTypes = new ObservableCollection<TransportModeUnitType>();
        }
        public int Id { get; set; }
        public string NameENG { get; set; }
        public string NameUKR { get; set; }

        public virtual ICollection<TransportModeUnitType> TransportModeUnitTypes { get; set; }

    }
}
