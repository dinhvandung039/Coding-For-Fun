using MakeCodeMoreOOP.Interfaces;

namespace MakeCodeMoreOOP.Helpers
{
    public class ShortDate : IValueFormatter
    {
        public string Format(object value) => $"{value:yyyy-MM-dd}";
    }
}
