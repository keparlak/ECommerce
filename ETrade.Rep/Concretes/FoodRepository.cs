using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
using ETrade.Ent;
using ETrade.Rep.Abstracts;

namespace ETrade.Rep.Concretes
{
    public class FoodRepository : BaseRepository<Foods>, IFoodRepository
    {
        public FoodRepository(Context context) : base(context)
        {
        }

        public List<FoodDTO> GetFoods()
        {
            return Set().Select(x => new FoodDTO
            {
                Id = x.FoodId,
                FoodName = x.FoodName
            }).ToList();
        }
    }
}