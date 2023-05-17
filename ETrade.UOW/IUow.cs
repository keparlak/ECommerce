using ETrade.Rep.Abstracts;

namespace ETrade.UOW
{
    public interface IUow
    {
        public IFoodRepository FoodRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IPropertyRepository PropertyRepository { get; }
        public IUserRepository UserRepository { get; }
        public IOrderDetailRepository OrderDetailRepository { get; }

        void Commit();
    }
}