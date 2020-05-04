using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lpg.App.Models
{
    public class CylinderViewModel
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public float GasWeight { get; set; }
        public float CylinderWeight { get; set; }
        public float TotalWeight { get; set; }
        public string Brand { get; set; }
    }
}
