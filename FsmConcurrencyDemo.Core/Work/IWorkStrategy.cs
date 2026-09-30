using System;
using System.Collections.Generic;
using System.Text;

namespace FsmConcurrencyDemo.Core.Work
{
	public interface IWorkStrategy
	{
		string Name { get; }
		void Execute();
	}

}
