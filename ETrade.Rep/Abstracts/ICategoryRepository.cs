using ETrade.Core;
using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.Rep.Abstracts
{
    public interface ICategoryRepository : IBaseRepository<Categories>
    {
        List<CategoriesDTO> GetCategories();
    }
}