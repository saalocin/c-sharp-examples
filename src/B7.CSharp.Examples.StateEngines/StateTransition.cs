using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7.CSharp.Examples.StateEngines
{
    public class StateTransition<P, C>
            where P : Enum
            where C : Enum
    {
        readonly P CurrentState;
        readonly C Command;

        public StateTransition(P currentState, C command)
        {
            CurrentState = currentState;
            Command = command;
        }

        public override int GetHashCode()
        {
            return 17 + 31 * CurrentState.GetHashCode() + 31 * Command.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            StateTransition<P,C> other = obj as StateTransition<P,C>;
            return other != null && this.CurrentState.CompareTo(other.CurrentState) == 0 && this.Command.CompareTo(other.Command) == 0;
        }
    }
}
