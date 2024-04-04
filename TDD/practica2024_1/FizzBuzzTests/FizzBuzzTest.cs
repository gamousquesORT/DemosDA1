using FizzBuzzLogic;

namespace FizzBuzzTests;
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
        FizzBuzzLogic si el número es divisible por 3 y 5
        Si el número no es divisible por 3 ni 5 retorna el número
 *
 * DEfinir tests
 *      1. Se llama a la funcion para ver que no exista la clase y todo funciona
 *      2. Dado 3 retorna Fizz
 *      3. Dado 5 retorna Buzz
 *      4. Dado 2 retorna "2"
 *      5.Se pasa un número divisible por 3 y retorna Fizz
 *      6. Se pasa un número divisible por 5 y retorna Buzz
 *      7. se pasa un numero divisble por 3 y 5 y retorna FizzBuzzLogic
 *      8. Se pasa un número no divisble por 3 y retorna el numero como string
 *      9. se pasa cero FizzBuzz
 *      10. se pasa un número negativo y retorna excepción
 *
 */

[TestClass]
public class FizzBuzzTest
{
    [TestMethod]
    public void ShouldReturnFizzGivenAValueOfThree()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.GetFizzBuzz(3);
        Assert.AreEqual("Fizz", result);
    }

    
    /*
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldReturnArgumentExceptionGivenAValueOfNegative_1()
    {
        FizzBuzz fb = new FizzBuzz();
        string result = fb.CheckFizzBuzz(-1);
    }
    */
}
