using System;
using System.Collections.Generic;
using System.Text;

namespace FsmConcurrencyDemo.Core.Work;

public class CpuBoundWork : IWorkStrategy
{
	public string Name => "CPU-bound";

	public void Execute()
	{
		double sum = 0;
		for (int i = 0; i < 1_000_000; i++)
			sum += Math.Sqrt(i);

		Console.WriteLine($"[Work] {Name} finished. Sum={sum:F2}");
	}
}

