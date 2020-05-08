using Lpg.Data.Entity;
using Lpg.Data.Enty;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lpg.Data
{
    public class LpgDbSeed
    {
        private readonly LpgDbContext _context;

        public LpgDbSeed(LpgDbContext context)
        {
            _context = context;
        }

        public void Init()
        {
            if (_context.Database.EnsureCreated())
            {
                if (!_context.Cylinder.Any())
                {
                    _context.Cylinder.AddRange(
                        new Entity.Cylinder { Brand = "PetroMax", Size = "22MM", Color = "Pink", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "PetroMax", Size = "20MM", Color = "Pink", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "Euro Gaz", Size = "22MM", Color = "Silver,Red", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "Euro Gaz", Size = "20MM", Color = "Silver,Red,Silver", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "PetroMax", Size = "22MM", Color = "Pink", GasWeight = 25, CylinderWeight = 15, TotalWeight = 40 },
                        new Entity.Cylinder { Brand = "Euro Gaz", Size = "22MM", Color = "Black", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "Universal", Size = "22MM", Color = "Yellow", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "Bexicom", Size = "22MM", Color = "Pink", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "Bashudhara", Size = "22MM", Color = "Blue", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 },
                        new Entity.Cylinder { Brand = "Jamuna", Size = "22MM", Color = "Green", GasWeight = 12, CylinderWeight = 25, TotalWeight = 25 }
                        );
                    _context.SaveChanges();
                }
                if (!_context.Supplier.Any())
                {
                    _context.Supplier.AddRange(
                        new Entity.Supplier { CompanyName = "PetroMax Lpg Company", Address = "Dhaka Bangladesh", Contact = "0171298989" },
                        new Entity.Supplier { CompanyName = "Euro Gaz Lpg Company", Address = "Dhaka Bangladesh", Contact = "45345345" },
                        new Entity.Supplier { CompanyName = "Laufghs Gaz Lpg Company", Address = "Dhaka Bangladesh", Contact = "454" },
                        new Entity.Supplier { CompanyName = "Bexicom Lpg Company", Address = "Dhaka Bangladesh", Contact = "4545" }

                        );
                    _context.SaveChanges();
                }
                if (!_context.PurchaseOrder.Any())
                {
                    _context.PurchaseOrder.AddRange(
                       new PurchaseOrder
                       {
                           PoNumber = "qw",
                           Address = "dff",
                           DeliveryDate = DateTime.Now,
                           Description = "N/A",
                           PoDate = DateTime.Now,
                           PoStatuse = 1,
                           TermPoint = "D23",
                           WaresHouseId = 1,
                           Orders = new List<Order> 
                           {
                               new Order{CylinderId=1,Qauntity=12,UnitPrice=345},
                               new Order{CylinderId=2,Qauntity=123,UnitPrice=245},
                           },
                           SupplierId=2

                       },
                       new Entity.PurchaseOrder { PoNumber = "23", Address = "dff", DeliveryDate = DateTime.Now, Description = "N/A", PoDate = DateTime.Now, PoStatuse = 1, TermPoint = "D23", WaresHouseId = 1 });
                    _context.SaveChanges();
                }

            }
        }
    }
}
