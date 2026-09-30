using System;
using System.Collections.Generic;
using System.Text;

namespace FsmConcurrencyDemo.Core.Work;

public class IoBoundWork : IWorkStrategy
{
	public string Name => "IO-bound";

	public void Execute()
	{
		Console.WriteLine($"[Work] {Name} simulated (sleep)");
		Thread.Sleep(500);
	}
}

