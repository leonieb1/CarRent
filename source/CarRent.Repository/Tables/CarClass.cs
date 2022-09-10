using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Repository.Tables
{
    public class CarClass
    {
        public string CarClassID { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
