using BCrypt.Net;
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

        public Users Login(Users user)
        {
            try
            {
                var loginUser = Find(user.UserId);

                return loginUser;
            }
            catch (Exception)
            {
                var u = new Users();
                return u;
            }
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(Users user)
        {
            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                user.UpdatedAt = DateTime.Now;
                user.CreatedAt = DateTime.Now;
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