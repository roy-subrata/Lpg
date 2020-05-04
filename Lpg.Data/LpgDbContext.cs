using Lpg.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lpg.Data.Enty
{
    public class LpgDbContext:DbContext
    {
        public LpgDbContext(DbContextOptions<LpgDbContext> options):base(options)
        {

        }

        public DbSet<Cylinder> Cylinder { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<ClylinderSaleBuyType> ClylinderSaleBuyType { get; set; }


    }
}
