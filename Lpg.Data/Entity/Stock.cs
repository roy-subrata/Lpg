using System;
using System.Collections.Generic;
using System.Text;

namespace Lpg.Data.Entity
{
   public class Stock:BaseEntity
    {
        public string StockNo { get; set; }
        public double QuantityInStock{ get; set; }
        public double UnitPrice  { get; set; }
        public int CylinderId { get; set; }
        public Cylinder Cylinder { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
