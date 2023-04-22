namespace Decorator_Wrapper_Pattern
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;
        // the object is received that wrapped by decorator
        protected MilkTeaDecorator(IMilkTea milkTea)
        {
            _milkTea = milkTea;
        }

        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
