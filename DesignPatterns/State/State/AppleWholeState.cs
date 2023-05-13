namespace State.State
{
    public class AppleWholeState : AppleBaseState
    {
        public override void EnterState(AppleStateManager appleWholeState)
        {
            Console.WriteLine("Hello from the whole state");
        }

        public override void OnCollisionEnter(AppleStateManager appleWholeState, Collision collision)
        {
            throw new NotImplementedException();
        }

        public override void UpdateState(AppleStateManager appleWholeState)
        {
            throw new NotImplementedException();
        }
    }
}