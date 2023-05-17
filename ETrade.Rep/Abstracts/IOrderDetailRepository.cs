using ETrade.Core;
using ETrade.Ent;

namespace ETrade.Rep.Abstracts
{
    public interface IOrderDetailRepository : IBaseRepository<OrderDetails>
    {
        List<OrderDetails> GetOrderDetails(Guid Id);
    }
}