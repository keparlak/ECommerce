using System.ComponentModel.DataAnnotations;

namespace ETrade.Ent
{
    public class Categories : Base
    {
        [Key]
        public Guid CategoryId { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Foods> Foods { get; set; }
    }
}