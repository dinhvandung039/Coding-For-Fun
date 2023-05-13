using State.State;

namespace State;

public class AppleStateManager
{
    AppleBaseState _currentState;
    public AppleGrowingState _growingState = new();
    public AppleChewState _chewState = new();
    public AppleRottenState _rottenState = new();
    public AppleWholeState _wholeState = new();

    void Start()
    {
        _currentState = _growingState;
        _currentState.EnterState(this);
    }

    void OnCollisionEnter(Collision collision)
    {
        _currentState.OnCollisionEnter(this, collision);
    }

    void Update()
    {
        _currentState.UpdateState(this);
    }

    public void SwitchState(AppleBaseState state)
    {
        _currentState = state;
        state.EnterState(this);
    }
}
