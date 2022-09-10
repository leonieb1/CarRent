using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Repository.Tables
{
    public class Car
    {
        public string CarID { get; set; }
        public string CarNumber { get; set; }
        public string CarClassID { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public virtual CarClass CarClass { get; set; }
    }
}
