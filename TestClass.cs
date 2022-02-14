using Xunit;

public class TestClass {

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(1, 2, 0.5)]
    [InlineData(1, 0, double.PositiveInfinity)]
    [InlineData(-1, 0, double.NegativeInfinity)]
    public void divideTest(double x, double y, double expected)
    {
        // Actual
        double actual = Program.divide(x, y);
        
        // Assert
        Assert.Equal(expected, actual);     
    }  

    [Theory]
    [InlineData(-19, false)]
    [InlineData(25, true)]
    public void scpTest(double x, bool expected)
    {
        // Actual
        bool actual = Program.scp(x);
        
        // Assert
        Assert.Equal<bool>(expected, actual);     
    }     

}