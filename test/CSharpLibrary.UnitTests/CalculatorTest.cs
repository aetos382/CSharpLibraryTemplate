using Xunit;

namespace CSharpLibrary.UnitTests;

public class CalculatorTest
{
    [Fact]
    public void AddTest()
    {
        var actual = Calculator.Add(3, 5);

        Assert.Equal(8, actual);
    }
}
