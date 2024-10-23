namespace Academy2024Lib.Operations;

public class AddNumberOperation : Operation
{
    private readonly double _numberToAdd;

    public AddNumberOperation(double numberToAdd)
    {
        _numberToAdd = numberToAdd;
    }

    public override double Apply(double n)
    {
        return n + _numberToAdd;
    }
}
