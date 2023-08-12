using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class TransportationType
    {
        public int Id { get; set; }
        public int TransportModeUnitTypeId { get; set; }
        public virtual TransportModeUnitType TransportModeUnitType { get; set; }
        
    }
}
