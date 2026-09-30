namespace FsmConcurrencyDemo.Core.StateMachine.States;

public class ProcessingState : IState
{
	public string Name => "Processing";

	public void Handle(StateContext context)
	{
		Console.WriteLine("[FSM] Processing → Completed");
		context.SetState(new CompletedState());
	}
}
