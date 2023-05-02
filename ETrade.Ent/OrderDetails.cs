using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class OrderDetails
    {
        [Key]
        public Guid Id { get; set; }

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