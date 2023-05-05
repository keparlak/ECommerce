using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class PropertiesModel : BaseCrud
    {
        public Properties Properties { get; set; } = new Properties();

        // we need select-option prop so we use foodDTO
        public List<FoodDTO> FoodDTOs { get; set; }

        //public List<PropertiesDTO> PropertiesDTO { get; set; }
    }
}