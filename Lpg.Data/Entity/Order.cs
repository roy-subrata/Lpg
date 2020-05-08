namespace Lpg.Data.Entity
{
    public class Order : BaseEntity
    {
        public float Qauntity { get; set; }
        public double UnitPrice { get; set; }
        public int CylinderId { get; set; }

        public Cylinder Cylinder { get; set; }

        public int PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }

    }


}