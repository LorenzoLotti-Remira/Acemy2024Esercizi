using Academy2024Lib.Operations;
using FluentAssertions;

namespace Academy2024Lib.Tests;

public class OperationsTests
{
    [Theory]
    [InlineData(16, -729)]
    public void Operation_Multiplication(double number, double expectedResult)
    {
        Operation[] chain =
        [
            new SqrtOperation(),
            new AddNumberOperation(5),
            new SqrtOperation(),
            new CubeOperation(),
            new OperationWithNegation(new PowOperation(2))
        ];

        foreach (Operation operation in chain)
        {
            number = operation.Apply(number);
        }

        number.Should().Be(expectedResult);
    }

}
