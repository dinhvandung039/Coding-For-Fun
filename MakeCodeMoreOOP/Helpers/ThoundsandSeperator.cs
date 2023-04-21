namespace MakeCodeMoreOOP.Helpers
{
    public class ThoundsandSeperator : IValueFormatter
    {
        public string Format(object value) => $"{value:NO}";
    }
}
