namespace State;
public abstract class AppleBaseState
{
    public abstract void EnterState(AppleStateManager appleStateManager);
    public abstract void UpdateState(AppleStateManager appleStateManager);
    public abstract void OnCollisionEnter(AppleStateManager appleStateManager, Collision collision);
}
