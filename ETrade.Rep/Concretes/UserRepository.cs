using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }

        public bool Login()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(Users user)
        {
            try
            {
                Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}