using ETrade.Dal;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
	public class Uow : IUow
	{
		public readonly Context context;
		public readonly IFoodRepository foodRepository;
		public readonly IOrderRepository orderRepository;
		public readonly IOrderDetailRepository orderDetailRepository;
		public readonly IUserRepository userRepository;
		public readonly IPropertyRepository propertyRepository;
		public readonly ICategoryRepository categoryRepository;

		public Uow(Context context, IFoodRepository foodRepository, IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, IUserRepository userRepository, IPropertyRepository propertyRepository, ICategoryRepository categoryRepository)
		{
			this.context = context;
			this.foodRepository = foodRepository;
			this.orderRepository = orderRepository;
			this.orderDetailRepository = orderDetailRepository;
			this.userRepository = userRepository;
			this.propertyRepository = propertyRepository;
			this.categoryRepository = categoryRepository;
			// özelliklerin kendisine atandığı yer
			CategoryRepository = categoryRepository;
			OrderRepository = orderRepository;
			PropertyRepository = propertyRepository;
			UserRepository = userRepository;
			OrderDetailRepository = orderDetailRepository;
			FoodRepository = foodRepository;
		}

		public ICategoryRepository CategoryRepository { get; }

		public IOrderRepository OrderRepository { get; }

		public IPropertyRepository PropertyRepository { get; }

		public IUserRepository UserRepository { get; }

		public IOrderDetailRepository OrderDetailRepository { get; }

		public IFoodRepository FoodRepository { get; }

		public void Commit()
		{
			context.SaveChanges();
		}
	}
}