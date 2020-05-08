using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lpg.App.Models
{
    public class OrderViewModel
    {

        public int Id { get; set; }
        public float Qauntity { get; set; }
            public double UnitPrice { get; set; }
            public int CylinderId { get; set; }

            public CylinderViewModel Cylinder { get; set; }

            public int PurchaseOrderId { get; set; }
            public PurchaseOrderViewModel PurchaseOrder { get; set; }

        

    }
}
