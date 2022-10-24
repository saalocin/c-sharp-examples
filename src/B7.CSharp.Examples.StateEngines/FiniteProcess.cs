using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7.CSharp.Examples.StateEngines
{
    public abstract class FiniteProcess<P, C>
            where P : Enum
            where C : Enum
    {

        IDictionary<StateTransition<P, C>, P> transitions;

        public P CurrentState { get; private set; }

        protected abstract P StartingProcessState { get; }

        protected abstract IDictionary<StateTransition<P, C>, P> TransitionContext { get; }

        protected FiniteProcess()
        {
            CurrentState = StartingProcessState;
            transitions = TransitionContext;
        }

        public P GetNext(C command)
        {
            var transition = new StateTransition<P,C>(CurrentState, command);
            P nextState;
            if (!transitions.TryGetValue(transition, out nextState))
                throw new Exception("Invalid transition: " + CurrentState + " -> " + command);
            return nextState;
        }

        public P MoveNext(C command)
        {
            CurrentState = GetNext(command);
            return CurrentState;
        }
    }
}
