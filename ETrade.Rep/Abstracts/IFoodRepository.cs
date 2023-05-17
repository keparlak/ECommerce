using ETrade.Core;
using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.Rep.Abstracts
{
    public interface IFoodRepository : IBaseRepository<Foods>
    {
        List<FoodDTO> GetFoods();
    }
}