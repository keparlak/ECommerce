using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class FoodsRepos : BaseRepository<Foods>, IFoodsRepos
    {
        public FoodsRepos(Context context) : base(context)
        {
        }

        public List<Foods> GetFoods()
        {
            return Set().Select(x => new Foods
            {
                Id = x.Id,
                FoodName = x.FoodName,
                CategoryId = x.CategoryId,
                PropertyId = x.PropertyId,
                Description = x.Description,
                Img = x.Img,
                UpdatedAt = x.UpdatedAt,
                CreatedAt = x.CreatedAt,
            }).ToList();
        }
    }
}