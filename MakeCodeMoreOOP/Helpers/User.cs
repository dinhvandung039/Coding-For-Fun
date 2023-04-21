namespace MakeCodeMoreOOP.Helpers
{
    public class User
    {
        [CsvInfo(typeof(EscapedText))]
        public string UserName => _userName.Value;

        [CsvInfo(typeof(ShortDate))]
        public DateTimeOffset Created { get; set; }

        [CsvInfo(typeof(ThoundsandSeperator))]
        public decimal CurrentBalance { get; set; }

        private readonly UserName _userName;

        public User(UserName userName)
        {
            _userName = userName;
        }

        public string ToCSV()
        {
            var properties = GetType()
                .GetProperties()
                .ToDictionary(
                    prop => prop,
                    info => info.GetCustomAttribute<CsvInfoAttribute>());

            string csvRow = string.Join(",", properties.Select(p => p.Value.Formatter.Format(value: p.Key.GetValue(this))));

            return csvRow;
        }
    }
}