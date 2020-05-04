namespace Lpg.Data.Entity
{
    public class Order:BaseEntity
    {
        public float Qauntity { get; set; }
        public int CylinderId { get; set; }
        public  Cylinder Cylinder { get; set; }
        public OrderType OrderType { get; set; }
    }

   public enum OrderType
    {
        Draft=1,

    }
}