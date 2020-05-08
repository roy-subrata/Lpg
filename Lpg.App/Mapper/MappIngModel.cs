using AutoMapper;
using Lpg.App.Models;
using Lpg.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lpg.App.Mapper
{
    public class MappingModel:Profile
    {
        public MappingModel()
        {
            CreateMap<Cylinder, CylinderViewModel>().ReverseMap();
            CreateMap<Supplier, SupplierViewModel>().ReverseMap();
            CreateMap<Order, OrderViewModel>().ReverseMap();

            CreateMap<PurchaseOrder, PurchaseOrderViewModel>().ReverseMap();
           
        }
    }
}
