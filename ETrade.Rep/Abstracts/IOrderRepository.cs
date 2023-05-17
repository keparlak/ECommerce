using ETrade.Core;
using ETrade.Ent;

namespace ETrade.Rep.Abstracts
{
    public interface IOrderRepository : IBaseRepository<Orders>
    {
        List<Orders> GetOrders(Guid Id);
    }
}