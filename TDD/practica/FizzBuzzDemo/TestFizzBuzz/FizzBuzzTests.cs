using System;
using System.Security;
using FizzBuzzLogic;
using Xunit;


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
 *      2. Se pasa un número divisible por 3 y retorna Fizz
 *      3. Se pasa un número divisible por 5 y retorna Buzz
 *      4. se pasa un numero divisble por 2 y 5 y retorna FizzBuzzLogic
 *      4. Se pasa un número no divisble por 3 y retorna el numero como string
 *      5. se pasa nulo y retorna excepción
 *      6. se pasa un número negativo y retorna excepción
 * 
 */
namespace TestFizzBuzz
{
    public class UnitTest1
    {
        private FizzBuzz fb = new FizzBuzz();
        
        [Fact]
        public void Given3_returns_Fizz()
        {
            //Arrange
            //Act
            String got = fb.CheckNumber(3);
            //Assert
            Assert.Equal("Fizz", got);
        }

        [Fact]
        public void Given5_returns_Buzz()
        {
            String got = fb.CheckNumber(5);
            Assert.Equal("Buzz", got);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void Given15_returns_FizzBuzz(int num)
        {
            String got = fb.CheckNumber(num);
            Assert.Equal("FizzBuzz", got);
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(4)] 
        [InlineData(7)]
        [InlineData(82)]
        public void GivenANubmerNotDivisibleby3or5_return_theNumber(int num)
        {
            String got = fb.CheckNumber(num);
            Assert.Equal(num.ToString(), got);
            
        }

        [Fact]
        public void GivenACeroOrNegativeNumber_ReturnArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => fb.CheckNumber(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => fb.CheckNumber(-4));

        }

        [Fact]
        public void GivenAnArray_ReturnProperFizzBuzz()
        {
                int[] given = new int[] {1,2,3,4, 5, 15, 18};
                String[] got =  fb.CheckNumberArray(given);
                String[] want = new string[] { "1", "2", "Fizz", "4", "Buzz", "FizzBuzz", "Fizz" };
                Assert.Equal(want, got);
                
        }

    }

}