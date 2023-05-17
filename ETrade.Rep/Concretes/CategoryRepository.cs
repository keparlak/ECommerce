using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
using ETrade.Ent;
using ETrade.Rep.Abstracts;

namespace ETrade.Rep.Concretes
{
    public class CategoryRepository : BaseRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {
        }

        public List<CategoriesDTO> GetCategories()
        {
            return Set().Select(x => new CategoriesDTO
            {
                CategoryName = x.CategoryName,
                Id = x.CategoryId
            }).ToList();
        }
    }
}