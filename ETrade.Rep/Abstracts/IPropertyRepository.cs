using ETrade.Core;
using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.Rep.Abstracts
{
    public interface IPropertyRepository : IBaseRepository<Properties>
    {
        List<PropertiesDTO> GetProperties();
    }
}