static class Factory
{
    public static IPosition Create<T>() where T : IPosition, new()
    {
        return new T();
    }
}
