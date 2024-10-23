using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy2024Lib.Operations;

public class PowOperation : Operation
{
    private readonly double _exponent;

    public PowOperation(double exponent)
    {
        _exponent = exponent;
    }

    public override double Apply(double n)
    {
        return Math.Pow(n, _exponent);
    }
}
