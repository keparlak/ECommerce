using ETrade.Core;
using ETrade.Ent;

namespace ETrade.Rep.Abstracts
{
    public interface IUserRepository : IBaseRepository<Users>
    {
        public Users Login(Users user);

        public void Logout();

        public bool Register(Users user);
    }
}