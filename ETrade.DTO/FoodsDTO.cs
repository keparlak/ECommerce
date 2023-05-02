using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DTO
{
    public class FoodsDTO
    {
        public Guid Id { get; set; }
        public string FoodName { get; set; }
        public string Properties { get; set; }
        public string CategoryName { get; set; }
    }
}