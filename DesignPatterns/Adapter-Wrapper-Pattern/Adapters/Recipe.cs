namespace Adapter_Wrapper_Pattern.Adapters
{
    public record Recipe
    {
        public string Name { get; set; }
        public int PrepTimeMinutes { get; set; }
        public Recipe(string name, int prepTimeMinutes)
        {
            Name = name;
            PrepTimeMinutes = prepTimeMinutes;
        }
    }
}
