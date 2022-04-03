using System;
using Xunit;
using FizzBuzz;

/*
 *
 * Estructura de los test
        Arrange
        Act
        Assert
 *
 * Reglas FizzBuzz
 * Crear una clase que tenga un método que dado un número retorne:
        Fizz si el número es divisible por 3
        Buzz si el número es divisible por 5
        FizzBuzz si el número es divisible por 3 y 5
        Si el número no es divisible por 3 ni 5 retorna el número 
 *
 * DEfinir tests
 *      1. Se llama a la funcion para ver que no exista la clase y todo funciona
 *      2. Se pasa un número divisible por 3 y retorna Fizz
 *      3. Se pasa un número divisible por 5 y retorna Buzz
 *      4. se pasa un numero divisble por 2 y 5 y retorna FizzBuzz
 *      4. Se pasa un número no divisble por 3 y retorna el numero como string
 *      5. se pasa nulo y retorna excepción
 *      6. se pasa un número negativo y retorna excepción
 * 
 */
namespace TestFizzBuzz
{
    public class UnitTest1
    {
        [Fact]
        public void Dado3retornaFiz()
        {
            //Arrange
            FizzBuzz.FizzBuzz fb = new FizzBuzz.FizzBuzz();
            //Act
            String got = fb.CheckNumber(3);
            //Assert
            Assert.Equal("Fizz", got);
        }
    }

}