namespace State.State
{
    public class AppleGrowingState : AppleBaseState
    {
        public override void EnterState(AppleStateManager appleGrowingState)
        {
            Console.WriteLine("Hello from Growing State");
        }

        public override void OnCollisionEnter(AppleStateManager appleGrowingState, Collision collision)
        {
            Console.WriteLine("");
        }

        public override void UpdateState(AppleStateManager appleGrowingState)
        {
            Console.WriteLine("Updatae Apple Growing State");
            appleGrowingState.SwitchState(appleGrowingState._wholeState);
        }
    }
}
