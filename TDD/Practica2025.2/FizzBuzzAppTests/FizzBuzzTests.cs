using FizzBuzzApp;

namespace FizzBuzzAppTests;
using FizzBuzzApp;
/*
 * Reglas FizzBuzzLogic
 * Crear una que tenga un método que dado un número retorne:
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
 *         Se pasa 6 y retorna Fizz
 *      3. Se pasa un número divisible por 5 y retorna Buzz
 *          Se pasa un 5 => Buzz
 *          Se pasa un 10 => Buzz
 *          Se pasa un 100 => Buzz
 *      4. se pasa un numero divisble por 3 y 5 y retorna FizzBuzz
 *          se pasa 15 => FizzBuzz
 *          se pasa 30 => FizzBuzz
 *      5. Se pasa un número no divisble por 3 ni por 5 retorna el número como string
 *          se pasa 1 => 1
 *          se pasa 32 => 32
 *          se pasa 0  => 0
 *      6. se pasa un número negativo y retorna ArgumentOutOfRangeException
 *          se pasa -1 => excep
 *      7. se pasa un número mayor que 100 retorna ArgumentOutOfRangeException
 *
 */ 

[TestClass]
public sealed class FizzBuzzTests
{
    [TestMethod]
    public void ShouldReturnFizzGiven3()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "Fizz";
        
        // Act
        string result = fb.Convert(3);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
/*    
    [TestMethod]
    public void ShouldReturnFizzGiven6()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "Fizz";
        
        // Act
        string result = fb.Convert(6);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ShouldReturnBuzzGiven5()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "Buzz";
        
        // Act
        string result = fb.Convert(5);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ShouldReturnBuzzGiven10()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "Buzz";
        
        // Act
        string result = fb.Convert(10);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ShouldReturnBuzzGiven100()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "Buzz";
        
        // Act
        string result = fb.Convert(100);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ShouldReturnFizzBuzzGiven15()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "FizzBuzz";
        
        // Act
        string result = fb.Convert(15);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ShouldReturnFizzBuzzGiven30()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "FizzBuzz";
        
        // Act
        string result = fb.Convert(30);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ShouldReturn1Given1()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "1";
        
        // Act
        string result = fb.Convert(1);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    
    [TestMethod]
    public void ShouldReturn32Given32()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "32";
        
        // Act
        string result = fb.Convert(32);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ShouldReturnFizzBuzzGiven0()
    {
        // Arrange
        var fb = new FizzBuzz();
        string expected = "FizzBuzz";
        
        // Act
        string result = fb.Convert(0);
        
        //Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShouldThrowArgumentOutOfRangeExceptionGivenNegativeNumbers()
    {
        // Arrange
        var fb = new FizzBuzz();
        // Act Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(()=> fb.Convert(-1));
    }
    

    [TestMethod]
    public void ShouldThrowArgumentOutOfRangeExceptionGivenNumbersLargerThan100()
    {
        // Arrange
        var fb = new FizzBuzz();
        // Act Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(()=> fb.Convert(101));
    }
    */
}