using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
    public interface IUow
    {
        public IFoodsRepos foodsRepos { get; }
        //public IFoodRepos categoryRepos { get; }
        //public IFoodRepos orderDetailRepos { get; }
        //public IFoodRepos propertyRepos { get; }
        //public IFoodRepos userRepos { get; }
        //public IFoodRepos orderRepos { get; }

        void Commit();
    }
}