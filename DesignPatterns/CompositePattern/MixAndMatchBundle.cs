using CompositePattern;

public class MixAndMatchBundle : TeaCarton
{
    protected List<TeaCarton> SubCartons = new();

    public override void Add(TeaCarton carton)
    {
        Console.WriteLine($"Adding a carton of {carton} to the MixAndMatchBundle.");
        SubCartons.Add(carton);
    }

    public override void BuildBundle(Dictionary<TeaCarton, int> order)
    {
        foreach (var (teaCarton, quantity) in order)
        {
            for (var i = 0; i < quantity; i++)
            {
                SubCartons.Add(teaCarton);
            }
        }
    }

    public override void Remove(TeaCarton carton)
    {
        Console.WriteLine($"Removing a carton of {carton} to the MixAndMatchBundle.");
        SubCartons.Remove(carton);
    }

    public override int GetNumberOfServings()
        => SubCartons.Sum(carton => carton.GetNumberOfServings());

    public override bool ContainsSubCarton() => false;
}