/// This Console Application is a mock example of some steps that might be part of client-side code for
/// generating these shapes by deep-copying them from a prototype as a means of construction.
/// 


List<IBlock> grid = new List<IBlock>();
grid.Add(BlockFactory.Create("Hello"));
grid.Add(BlockFactory.Create("123"));
grid.Add(BlockFactory.Create("11/02/2022"));

var block3 = (DatetimeBlock)grid[2].Clone();
block3.Format = "MM/dd/yyyy";
grid.Add(block3);

class BlockFactory
{
    public static IBlock Create(string content)
    {
        if (DateTime.TryParse(content, out var date))
        {
            return new DatetimeBlock
            {
                Format = "dd/MM/yyyy",
                DateTime = date,
            };
        }

        if (int.TryParse(content, out var num))
        {
            return new NumberBlock { Content = num };
        }

        return new TextBlock { Content = content };
    }
}

interface IBlock
{
    string Render { get; }
    IBlock Clone();
}

class TextBlock : IBlock
{
    public string Content { get; set; }
    public string Render => Content;

    public IBlock Clone()
    {
        return new TextBlock { Content = Content };
    }
}

class NumberBlock : IBlock
{
    public int Content { get; set; }
    public string Render => Content.ToString();

    public IBlock Clone()
    {
        return new NumberBlock { Content = Content };
    }
}

class DatetimeBlock : IBlock
{
    public DateTime DateTime { get; set; }
    public string Format { get; set; }

    public string Render => DateTime.ToString(Format);

    public IBlock Clone()
    {
        return new DatetimeBlock
        {
            DateTime = DateTime,
            Format = Format
        };
    }
}