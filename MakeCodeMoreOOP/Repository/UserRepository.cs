using MakeCodeMoreOOP.Helpers;

namespace MakeCodeMoreOOP.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> context = new();

        public UserRepository()
        {
        }

        public bool CreateAsync(User user)
        {
            try
            {
                context.Add(user);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<User> GetAll() => context.ToList();
    }
}
