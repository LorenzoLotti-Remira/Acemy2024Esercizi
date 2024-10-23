namespace Academy2024Lib.Operations;

public class OperationWithNegation : Operation
{
    private readonly Operation _operation;

    public OperationWithNegation(Operation operation)
    {
        _operation = operation;
    }

    public override double Apply(double n)
    {
        return -_operation.Apply(n);
    }
}
