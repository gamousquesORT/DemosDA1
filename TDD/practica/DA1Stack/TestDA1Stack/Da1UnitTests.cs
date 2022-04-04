using System;
using Xunit;
using DA1StackLogic;
using Xunit.Sdk;

/*
 * Requerimientos
 *  ver si esta vacío
 *  Agregar elementos 
 *  Sacar elementos
 *  Saber la cantidad de elementos que tiene
 *
 * Casos de prueba
        1.	Caso de prueba vacío
        2.	Crear un stack
        3.	Verificar que esta vacío
        4.	Verificar que luego de push no es vacío
        5.	Verificar que luego de un Push y un Pop esta vacío
        6.	Verificar que luego de dos push el tamaño es 2
        7.	En el caso 5 verificar si el size es 0
        8.	Agregar el assert de vació en todos los casos que tienen
        9.	Verificar que lance Excepción de underflow cuando se haga pop de un stack vacío
        10.	Verificar que luego de push de dos números hace pop de los dos números y queda vacío
        11.	Verificar que se puedan hacer push de  N números y el size sea N
        12. Verificar que si se supera el tamaño por defecto se lanza una excepción
 */
namespace TestDA1Stack
{
    public class Da1UnitTests 
    {
        private Da1Stack stack = new Da1Stack();
        
        [Fact]
        public void CreatStack_IsEmpty()
        {
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void AfterOnePush_NotEmpty()
        {
            stack.Push(1);
            Assert.False(stack.IsEmpty());
            Assert.Equal(1, stack.Size());
        }

        [Fact]
        public void AfterAPushAndAPop_isEmpty()
        {
            stack.Push(2);
            int got = stack.Pop();
            Assert.True(stack.IsEmpty());
            Assert.Equal(0, stack.Size());
        }

        [Fact]
        public void AfterTwoPush_SizeIsTwo()
        {
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(2, stack.Size());
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void PopEmpty_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(()=>stack.Pop());
        }

        [Fact]
        public void AfterPushing_TwoNumberandOnePop_retunsLastNumber()
        {
            stack.Push(80);
            stack.Push(81);
            int result = stack.Pop();
            Assert.Equal(81, result);
        }

        [Fact]
        public void AfterPushingOverSize_throwsOverflowException()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Assert.Throws<OverflowException>(() => stack.Push(7));
        }
    }
}