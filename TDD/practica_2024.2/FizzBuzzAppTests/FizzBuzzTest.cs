namespace FizzBuzzAppTests;

/*
 *
 * Estructura de los test
        Arrange
        Act
        Assert
 *
 * Reglas FizzBuzzLogic
 * Crear una  que tenga un método que dado un número retorne:
        Fizz si el número es divisible por 3
        Buzz si el número es divisible por 5
        FizzBuzz si el número es divisible por 3 y 5
        Si el número no es divisible por 3 ni 5 retorna el número
        Si el número es negativo  retorna un error
 *
 * Definir tests
 *      1. Se llama a la funcion para ver que no exista la clase
 *      2. Se pasa un número divisible por 3 y retorna Fizz
 *         Se pasa un 3 => Fizz
 *         Se pasa un 6 => Fizz
 *      3. Se pasa un número divisible por 5 y retorna Buzz
 *          Se pasa un 5 => Buzz
 *          Se pasa un 10 => Fizz
 *      4. se pasa un numero divisble por 3 y 5 y retorna FizzBuzz
 *          se pasa 15 => FizzBuzz
 *          se pasa un 30 => FizzBuzz
 *          se pasa un 0 +> FizzBuzz
 *      5. Se pasa un número no divisble por 3 y retorna el numero como string
 *          se pasa 1 retorna el "1"
 *          se pasa 2 retorna el "2"
 *      6. se pasa un número negativo y retorna excepción
 *      7. se pasa un número mayor que 100 retorna una excepción
 *
 */ 


[TestClass]
public class FizzFuzzTests
{
    [TestMethod]
    public void GivenInputIs_3_ThenReturnsFizz()
    {
    }
    
    [TestMethod]
    public void GivenAnInputOf_6_ThenReturnsFizz()
    {
    }
    
    [TestMethod]
    public void GivenAnInputOf_5_ThenReturnsBuzz()
    {
    }
    
    [TestMethod]
    public void GivenAnInputOf_10_ThenReturnsBuzz()
    {
    }
    
    [TestMethod]
    public void GivenAnInputOf_15_ThenReturnsFIzzBuzz()
    {
    }

    
    [TestMethod]
    public void GivenAnInputOf_30_ThenReturnsFIzzBuzz()
    {
    }
    
    [TestMethod]
    public void GivenAnInputOf_0_ThenReturnsFIzzBuzz()
    {
    }
    
    [TestMethod]
    public void GivenAnInputOf_1_ThenReturns_1()
    {
    }

    [TestMethod]
    public void GivenAnInputOf_2_ThenReturns_2()
    {
    }
    
    [TestMethod]
    public void GivenAnInputOf_100_ThenReturns_Buzz()
    {
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnInputOf_Anegative_1_ThenReturnsException()
    {
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnInputGreaterThan_100_ThenReturnsException()
    {
    }
}