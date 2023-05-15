class Programmer : IPosition
{
    string IPosition.Title
    {
        get { return "Programmer"; }
    }

    bool IPosition.RequestVacation()
    {
        return false;
    }
}
