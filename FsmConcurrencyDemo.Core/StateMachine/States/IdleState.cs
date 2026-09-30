using FsmConcurrencyDemo.Core.StateMachine;

namespace FsmConcurrencyDemo.Core.StateMachine.States;

public class IdleState : IState
{
	public string Name => "Idle";

	public void Handle(StateContext context)
	{
		Console.WriteLine("[FSM] Idle → Processing");
		context.SetState(new ProcessingState());
	}
}
