using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lpg.App.Models
{
    public class WareHouseViewModel
    {
        public int Id { get; set; }
        public string WareHouseName { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string City { get; set; }
        public string Province { get; set; }
        public string County { get; set; }


    }
}
