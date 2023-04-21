using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace RefactorCleanCodeTests;

public class RefactorCleanCodeTests
{
    [Fact]
    public void ShoudReturnThereAreNoAsGivenCountCeroAnd_A()
    {

        string result = Program.GetGuessStatistics('A', 0);
        Assert.Equal("There are no As", result);
    }
    
    [Fact]
    public void ShoudReturnThereIsOnAsGivenCountOfOneAnd_A()
    {

        string result = Program.GetGuessStatistics('A', 1);
        Assert.Equal("There is 1 A", result);
    }
    
    [Fact]
    public void ShoudReturnThereAreFiveCsGivenCountOfFiveAnd_C()
    {

        string result = Program.GetGuessStatistics('C', 5);
        Assert.Equal("There are 5 Cs", result);
    }
    
    [Fact]
    public void ShoudReturnExceptionGivenNegativeCountAnd_A()
    {
        Assert.Throws<ArgumentException>(() => Program.GetGuessStatistics('A', -5));
    }
    
}