using FizzBuzzlogic;
namespace FizzBuzzTest;

/*
 * * Reglas FizzBuzzLogic
 * Crear una clase que tenga un método que dado un número retorne:
        Fizz si el número es divisible por 3
        Buzz si el número es divisible por 5
        FizzBuzzLogic si el número es divisible por 3 y 5
        Si el número no es divisible por 3 ni 5 retorna el número 
 *
 * DEfinir tests
 *      1. Se llama a la funcion para ver que no exista la clase y todo funciona
 *      2. Se pasa un número divisible por 3 y retorna Fizz
 *      3. Se pasa un número divisible por 5 y retorna Buzz
 *      4. se pasa un numero divisble por 3 y 5 y retorna FizzBuzz
 *      4. Se pasa un número no divisble por 3 o 5 retorna el numero como string
 *      6. se pasa un número negativo y retorna excepción
 * 
 */
 
//Create fizzbuzz unit case test

public class FizzBuzzTests
{
    [Fact]
    public void Given_Three_returns_Fizz()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckNumber(3);
        Assert.Equal("Fizz", result);
    }
    [Fact]
    public void Given_Five_returns_Buzz()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckNumber(5);
        Assert.Equal("Buzz", result);
    }
    [Fact]
    public void Given_two_returns_two()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckNumber(2);
        Assert.Equal("2", result);
    }
    
    [Fact]
    public void Given_Fifteen_returns_FizzBuzz()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckNumber(15);
        Assert.Equal("FizzBuzz", result);
    }
    
    [Fact]
    public void Given_thirty_returns_FizzBuzz()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckNumber(30);
        Assert.Equal("FizzBuzz", result);
    }
    
    [Fact]
    public void Given_four_returns_Four()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckNumber(4);
        Assert.Equal("4", result);
    }
    
    [Fact]
    public void Given_NegativeNumber_returns_Exception()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Throws<ArgumentException>(() => fb.CheckNumber(-1));
    }
    
    [Theory]
    [InlineData(6)]
    [InlineData(12)]
    public void Given_NumberDivisibleByThree_returns_Fizz(int n)
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckNumber(n);
        Assert.Equal("Fizz", result);
    }

}