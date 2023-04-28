namespace BridgePattern
{
    // top level abstraction
    public abstract class Vehicle1
    {
        private Make make;
        public void Start()
        {
            make.Perform();
            make.StartCar();
        }
        public abstract bool AllowedToDrive(string person);
    }
    public abstract class Make
    {
        public abstract void Perform();
        public abstract void StartCar();
    }

    // implementation
    public class Lada2 : Make
    {
        public override void Perform()
        {
            throw new NotImplementedException();
        }

        public override void StartCar()
        {
            throw new NotImplementedException();
        }
    }
    public class Volvo2 : Make
    {
        public override void Perform()
        {
            throw new NotImplementedException();
        }

        public override void StartCar()
        {
            throw new NotImplementedException();
        }
    }

    // lower level abstraction
    public class Car2 : Vehicle1
    {
        public override bool AllowedToDrive(string person)
        {
            throw new NotImplementedException();
        }
    }
    public class Truck2 : Vehicle1
    {
        public override bool AllowedToDrive(string person)
        {
            throw new NotImplementedException();
        }
    }
}
