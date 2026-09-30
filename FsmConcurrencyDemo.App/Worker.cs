using FsmConcurrencyDemo.Core.StateMachine;
using FsmConcurrencyDemo.Core.StateMachine.States;
using FsmConcurrencyDemo.Core.Work;

namespace FsmConcurrencyDemo.App;

public class Worker
{
	private readonly int _id;
	private readonly StateContext _fsm;
	private readonly IWorkStrategy _strategy;

	public Worker(int id, IWorkStrategy strategy)
	{
		_id = id;
		_strategy = strategy;
		_fsm = new StateContext(new IdleState());
	}

	public void Run()
	{
		Console.WriteLine($"[Worker {_id}] Starting with strategy: {_strategy.Name}");

		_fsm.Process(); // Idle → Processing
		_strategy.Execute();
		_fsm.Process(); // Processing → Completed
		_fsm.Process(); // Completed → Idle
	}
}
