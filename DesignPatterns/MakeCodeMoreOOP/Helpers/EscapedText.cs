using MakeCodeMoreOOP.Interfaces;

namespace MakeCodeMoreOOP.Helpers
{
    public class EscapedText : IValueFormatter
    {
        public string Format(object value) => $"\"{value}\"";
    }
}
