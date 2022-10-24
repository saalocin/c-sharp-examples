using B7.CSharp.Examples.Ecommerce.Processes.Cart;
using B7.CSharp.Examples.StateEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CartStateTransition = B7.CSharp.Examples.StateEngines.StateTransition<B7.CSharp.Examples.Ecommerce.Processes.Cart.CartProcessState, B7.CSharp.Examples.Ecommerce.Processes.Cart.CartCommand>;

namespace B7.CSharp.Examples.Ecommerce.Processes
{
    public class CartProcess : FiniteProcess<CartProcessState, CartCommand>
    {
        protected override CartProcessState StartingProcessState => throw new NotImplementedException();

        protected override IDictionary<CartStateTransition, CartProcessState> TransitionContext
            => new Dictionary<CartStateTransition, CartProcessState>()
            {
                    { new CartStateTransition(CartProcessState.New, CartCommand.ItemAdd), CartProcessState.InProgress },
            };
    }
}
