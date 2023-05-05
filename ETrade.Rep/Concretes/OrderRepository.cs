using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class OrderRepository : BaseRepository<Orders>, IOrderRepository
    {
        public OrderRepository(Context context) : base(context)
        {
        }

        //public List<Orders> GetOrders()
        //{
        //return Set().Select(x => new Orders
        //{
        //    OrderId = x.OrderId,
        //    UserId = x.UserId,
        //}).ToList();
        //}
    }
}