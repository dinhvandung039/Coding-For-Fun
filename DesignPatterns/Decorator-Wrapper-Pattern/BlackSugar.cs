namespace Decorator_Wrapper_Pattern
{
    public class BlackSugar : MilkTeaDecorator
    {
        public BlackSugar(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 3;
        }
    }
}
