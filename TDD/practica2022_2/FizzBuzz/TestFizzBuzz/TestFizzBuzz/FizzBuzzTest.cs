using FizzBuzzLogic;

namespace TestFizzBuzzTest;

/*
 * The number should be greater or equal to 0 and less or equal to 100
 * For multiples of three print Fizz instead of the number
 * For the multiples of five print Buzz instead of the number
 * For numbers which are multiples of both three and five print FizzBuzzLogic instead of the number
 */

public class FizzBuzzTest
{
    [Fact]
    public void ShouldReturn_Fizz_for_3()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.CheckFizzBuzz(3);
        Assert.Equal("Fizz", result);
    }
        
    [Fact]
    public void ShouldReturn_Buzz_for_5()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.CheckFizzBuzz(5);
        Assert.Equal("Buzz", result);
    }
        
    [Fact]
    public void ShouldReturn_FizzBuzz_for_15()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.CheckFizzBuzz(15);
        Assert.Equal("FizzBuzz", result);
    }
        
    [Fact]
    public void ShouldReturn_1_for_1()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.CheckFizzBuzz(1);
        Assert.Equal("1", result);
    }

    [Fact]
    public void ShouldReturn_FizzBuzz_for_30()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.CheckFizzBuzz(30);
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void ShouldReturnRangeException_for_101()
    {
        var fizzBuzz = new FizzBuzz();
        Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.CheckFizzBuzz(101));
    }
    
    [Fact]
    public void ShouldReturnRangeException_forLessThan_0()
    {
        var fizzBuzz = new FizzBuzz();
        Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.CheckFizzBuzz(-1));
    }
}