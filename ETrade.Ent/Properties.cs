using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETrade.Ent
{
    public class Properties : Base
    {
        [Key]
        public Guid PropertyId { get; set; }

        public Guid FoodId { get; set; }

        public string PropertyName { get; set; }
        public string UnitPrice { get; set; }

        [ForeignKey("FoodId")]
        public Foods Foods { get; set; }
    }
}