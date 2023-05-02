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
        private readonly Context context;

        public IFoodsRepos foodsRepos { get; }

        public Uow(Context context, IFoodsRepos foodRepos)
        {
            this.context = context;
            this.foodsRepos = foodRepos;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}