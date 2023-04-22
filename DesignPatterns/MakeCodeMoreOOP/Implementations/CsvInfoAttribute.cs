using MakeCodeMoreOOP.Helpers;
using MakeCodeMoreOOP.Interfaces;

namespace MakeCodeMoreOOP.Implementations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CsvInfoAttribute : Attribute
    {
        public IValueFormatter Formatter { get; }

        public CsvInfoAttribute(Type formatter)
        {
            formatter ??= typeof(NoFormatting);
            if (!formatter.IsAssignableFrom(typeof(IValueFormatter)))
                throw new ArgumentException($"Must implement {nameof(IValueFormatter)}", nameof(formatter));

            bool noDefaultConstructor = formatter.GetConstructor(Type.EmptyTypes) is null;
            if (noDefaultConstructor)
                throw new ArgumentException("Must have a defautl constructor", nameof(formatter));

            Formatter = (IValueFormatter)Activator.CreateInstance(formatter);
        }
    }
}
