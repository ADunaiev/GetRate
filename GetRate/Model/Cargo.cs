using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRate.Model
{
    public class Cargo
    {
        public Cargo()
        {
            //Requests = new List<Request>();
        }
        public int Id { get; set; }
        public string NameENG { get; set; }
        public string NameUKR { get; set; }
        public string Code { get; set; }

        //public virtual ICollection<Request> Requests { get; set; }
    }
}
