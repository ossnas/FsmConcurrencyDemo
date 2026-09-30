

namespace FsmConcurrencyDemo.Core.StateMachine;

public class StateContext
{
	private IState _current;

	public StateContext(IState initial)
	{
		_current = initial;
	}

	public void SetState(IState state)
	{
		_current = state;
	}

	public void Process()
	{
		_current.Handle(this);
	}
}
