using MakeCodeMoreOOP.Helpers;

namespace MakeCodeMoreOOP.Repository
{
    public interface IUserRepository
    {
        bool Create(User user);
        IEnumerable<User> GetAll();
    }
}
