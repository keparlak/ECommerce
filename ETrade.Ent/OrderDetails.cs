using System.ComponentModel.DataAnnotations.Schema;

namespace ETrade.Ent
{
    public class OrderDetails : Base
    {
        public Guid FoodId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Guid OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Orders Orders { get; set; }

        [ForeignKey("FoodId")]
        public Foods Foods { get; set; }
    }
}