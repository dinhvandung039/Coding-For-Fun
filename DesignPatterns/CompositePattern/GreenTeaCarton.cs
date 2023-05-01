using CompositePattern;

public class GreenTeaCarton : TeaCarton
{
    public override int GetNumberOfServings() => 24;
    public override bool ContainsSubCarton() => false;
}