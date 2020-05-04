using System;
using System.Collections.Generic;
using System.Text;

namespace Lpg.Data.Entity
{
    public class Cylinder:BaseEntity
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public float GasWeight { get; set; }
        public float CylinderWeight { get; set; }
        public float TotalWeight { get; set; }
        public string Brand { get; set; }
    }
}
