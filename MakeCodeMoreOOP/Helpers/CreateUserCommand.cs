namespace MakeCodeMoreOOP.Helpers
{
    public class CreateUserCommand
    {
        public Task<bool> ExecuteAsync(UserName username)
        {
            var user = new User(username);
            // save to database
            // var user1 = new User(new UserName("whatever"))
            var user1 = new User("whatever");

            return Task.FromResult(true);
        }
    }
}
