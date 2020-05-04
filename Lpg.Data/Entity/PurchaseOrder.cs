using System;
using System.Collections.Generic;
using System.Text;

namespace Lpg.Data.Entity
{
   public class PurchaseOrder:BaseEntity
    {
        public string PoNo { get; set; }
        public string CreatedBy { get; set; }
        public List<Order> Order { get; set; }
    }
}
