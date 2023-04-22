namespace Decorator_Wrapper_Pattern
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 1;
        }
    }
}
