using FizzBuzzProdCode;
namespace FizzBuzzTest;
/*
 *
 * Estructura de los test
        Arrange
        Act
        Assert
 *
 * Reglas FizzBuzzLogic
 * Crear una clase que tenga un método que dado un número retorne:
        Fizz si el número es divisible por 3
        Buzz si el número es divisible por 5
        FizzBuzz si el número es divisible por 3 y 5
        Si el número no es divisible por 3 ni 5 retorna el número
        Si el número es negativo o > 100 retorna un error
 *
 * Definir tests
 *      1. Se llama a la funcion para ver que no exista la clase 
 *      2. Se pasa un número divisible por 3 y retorna Fizz
 *         Se pasa un 3 => Fizz
 *      3. Se pasa un número divisible por 5 y retorna Buzz
 *          Se pasa un 5 => Buzz 
 *      4. se pasa un numero divisble por 3 y 5 y retorna FizzBuzz
 *          se pasa 15 => FizzBuzz
 *      5. Se pasa un número no divisble por 3 y retorna el numero como string
 *        Se pasa un 6 => Fizz
 *        Se pasa un 10 => Fizz
 *        Se pasa un 30 => FizzBuzz
 *      6. se pasa un número negativo y retorna excepción
 *      7. se pasa un número mayor que 100 retorna una excepción
 *
 */ 

public class FizzBuzzTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(12)]
    public void Given_Divisible_By_Three_Returns_Fizz(int param)
    {
        //arrange
        FizzBuzz fb = new FizzBuzz();
        string want = "Fizz";
        //act
        string got = fb.Convert(param);

        //assert
        Assert.Equal(want, got);
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void Given_Divisible_ByFive__Returns_Buzz(int param)
    {
        FizzBuzz fb = new FizzBuzz();
        string want = "Buzz";
        string got = fb.Convert(param);
        Assert.Equal(want, got);
    }
    
    [Fact]
    public void Given_Seven_return_Seven()
    {
        FizzBuzz fb = new FizzBuzz();
        string want = "7";
        string got = fb.Convert(7);
        Assert.Equal(want, got);
    }
    
    [Fact]
    public void Given_FifthTeen_return_FizzBuzz()
    {
        FizzBuzz fb = new FizzBuzz();
        string want = "FizzBuzz";
        string got = fb.Convert(15);
        Assert.Equal(want, got);
    }

    [Fact]
    public void Given_Negative_Number_return_Exception()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Throws<InvalidDataException>(() => fb.Convert(-8));
    }
    
    [Fact]
    public void Given_BiggerThan_100_return_Exception()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Throws<InvalidDataException>(() => fb.Convert(101));
    } 
}