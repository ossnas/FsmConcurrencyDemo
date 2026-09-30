namespace FsmConcurrencyDemo.Core.StateMachine.States;

public class CompletedState : IState
{
	public string Name => "Completed";

	public void Handle(StateContext context)
	{
		Console.WriteLine("[FSM] Completed → Idle (loop)");
		context.SetState(new IdleState());
	}
}

