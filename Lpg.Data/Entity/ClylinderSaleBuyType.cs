using System;
using System.Collections.Generic;
using System.Text;

namespace Lpg.Data.Entity
{
    public class ClylinderSaleBuyType:BaseEntity
    {
        
        public string TypeName { get; set; }
        public SaleBuyType SaleBuyType { get; set; }
    }

    public enum SaleBuyType
    {
        Sale=1,
        Buy=2
    }
}
