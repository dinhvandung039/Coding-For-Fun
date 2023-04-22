namespace MakeCodeMoreOOP.Helpers
{
    public class UserName
    {
        public string Value { get; }

        public UserName(string userName)
        {

            if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException("Must have a rule");
            if (userName.Length > 50) throw new ArgumentException("Cannot exceed 50 chars");

            Value = userName;
        }

        // new UserName("value")
        public static implicit operator UserName(string value) => new UserName(value);
    }
}
