using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class Orders : Base
    {
        public Guid UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public bool isDelivered { get; set; }

        [ForeignKey(nameof(UserId))]
        public Users Users { get; set; }
    }
}