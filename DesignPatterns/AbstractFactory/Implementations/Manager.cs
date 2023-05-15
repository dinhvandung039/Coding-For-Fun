class Manager : IPosition
{
    string IPosition.Title
    {
        get { return "Manager"; }
    }

    bool IPosition.RequestVacation()
    {
        return true;
    }
}
