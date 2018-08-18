using System;
using System.Collections.Generic;
using System.Text;

namespace Wincubate.CompositeExamples
{
    interface IOrderItem
    {
        string Description { get; }
        decimal Price { get; }
    }
}
