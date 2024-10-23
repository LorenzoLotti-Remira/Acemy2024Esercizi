using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy2024Lib.Operations;

public class SqrtOperation : Operation
{
    public override double Apply(double n)
    {
        return Math.Sqrt(n);
    }
}
