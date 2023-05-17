using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;

namespace ETrade.Rep.Concretes
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }

        public Users Login(Users user)
        {
            var dummyUser = new Users();
            try
            {
                var loginUser = Set().FirstOrDefault(x => x.UserName == user.UserName);
                if (loginUser != null)
                {
                    bool verified = BCrypt.Net.BCrypt.Verify(user.Password, loginUser.Password);
                    if (verified)
                    {
                        return loginUser;
                    }
                }
                return dummyUser;
            }
            catch (Exception)
            {
                return dummyUser;
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