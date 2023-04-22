using MakeCodeMoreOOP.Interfaces;

namespace MakeCodeMoreOOP.Helpers
{
    public class NoFormatting : IValueFormatter
    {
        public string Format(object value) => $"{value}";
    }
}
