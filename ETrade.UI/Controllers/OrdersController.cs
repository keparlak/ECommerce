using ETrade.Ent;
using ETrade.UI.Session;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrdersController : BaseController
    {
        private readonly Orders orders;

        public OrdersController(IUow uow, Orders orders) : base(uow)
        {
            this.orders = orders;
        }

        public IActionResult List()
        {
            Guid Id = SessionData.LoginUser.UserId;
            return View(uow.OrderRepository.GetOrders(Id));
        }

        public IActionResult Create()
        {
            orders.isDelivered = false;
            orders.TotalPrice = 0;
            orders.UpdatedAt = DateTime.Now;
            SessionData.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            orders.UserId = SessionData.LoginUser.UserId;
            orders.ShippingAddress = SessionData.LoginUser.ShippingAddress;
            orders.CreatedAt = DateTime.Now;
            uow.OrderRepository.Add(orders);
            uow.Commit();
            return RedirectToAction("List", "OrderDetails", new { Id = orders.OrderId });
        }
    }
}