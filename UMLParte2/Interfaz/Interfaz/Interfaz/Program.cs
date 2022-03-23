﻿using System;

namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new CalculadoraA();
            Console.WriteLine("Sumar 5 + 4 = {0}", calc.Sumar(5,4));
            Console.WriteLine("Restar 5 - 4 = {0}", calc.Restar(5,4));
            
            // Si quisiera escribir
            // calc.Multiplicar(3,5);
            // podria???
        }
    }
}