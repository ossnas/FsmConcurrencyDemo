using System;
using System.Collections.Generic;
using System.Text;

namespace FsmConcurrencyDemo.Core.StateMachine;

public interface IState
{
	string Name { get; }
	void Handle(StateContext context);
}
