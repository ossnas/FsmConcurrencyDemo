using System;
using System.Collections.Generic;
using System.Text;

namespace FsmConcurrencyDemo.Core.Work;

public static class WorkFactory
{
	public static IWorkStrategy Create(string type) =>
		type switch
		{
			"cpu" => new CpuBoundWork(),
			"io" => new IoBoundWork(),
			_ => new CpuBoundWork()
		};
}
