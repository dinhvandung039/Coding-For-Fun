class Clerk : IPosition
{
    int m_VacationDaysRemaining = 1;

    string IPosition.Title
    {
        get { return "Clerk"; }
    }

    bool IPosition.RequestVacation()
    {
        if (m_VacationDaysRemaining <= 0)
        {
            return false;
        }
        else
        {
            m_VacationDaysRemaining--;
            return true;
        }
    }
}
