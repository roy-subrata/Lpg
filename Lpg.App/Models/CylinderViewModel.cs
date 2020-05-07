using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Lpg.App.Models
{
    public class CylinderViewModel
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [DisplayName("G.Weight")]
        public float GasWeight { get; set; }
        [DisplayName("C.Weight")]

        public float CylinderWeight { get; set; }
        [DisplayName("T.Weight")]

        public float TotalWeight { get; set; }
        public string Brand { get; set; }
    }
}
