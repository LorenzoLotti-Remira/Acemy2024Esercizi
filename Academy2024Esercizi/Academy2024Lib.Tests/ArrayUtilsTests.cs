using FluentAssertions;

namespace Academy2024Lib.Tests;

public class ArrayUtilsTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    [InlineData(new int[] { 30, -5, 2 }, 27)]
    [InlineData(new int[] { 0, 0, 0 }, 0)]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 7 }, 7)]
    public void Sum_of_array_should_work(int[] array, int expectedResult)
    {
        ArrayUtils.Sum(array).Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(new int[] { 30, -5, 2 }, new int[] { -5, 2, 30 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { -1, -2, -3 }, new int[] { -3, -2, -1 })]
    public void SelectionSort_should_work(int[] array, int[] expectedResult)
    {
        ArrayUtils.SelectionSort(array);
        array.Should().BeEquivalentTo(expectedResult);
    }
}