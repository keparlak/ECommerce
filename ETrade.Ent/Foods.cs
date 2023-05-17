using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETrade.Ent
{
    public class Foods : Base
    {
        [Key]
        public Guid FoodId { get; set; }

        public string FoodName { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }

        public ICollection<Properties> Properties { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}