﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lpg.Data.Entity
{
    public class PurchaseOrder : BaseEntity
    {
  
        public string PoNumber { get; set; }
        public string TermPoint { get; set; }
        public int WaresHouseId { get; set; }

        public int PoStatuse { get; set; }

        public DateTime PoDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }

        public string RefNumberIn { get; set; }
        public string RefNumberIEx { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<Order> Orders { get; set; }
    }
}
