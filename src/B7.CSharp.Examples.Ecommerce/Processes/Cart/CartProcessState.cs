
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7.CSharp.Examples.Ecommerce.Processes.Cart
{
    public enum CartProcessState
    {
        Unknown = 0,
        New = 1,
        InProgress = 2,
        CheckoutStarted = 3,
        PaymentReceived = 4,
        Done
    }
}
