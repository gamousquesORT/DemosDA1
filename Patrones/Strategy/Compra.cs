﻿namespace Strategy.Domain;

public class Compra
{
    // Muchos datos
    // ....

    public int Total { get; set; }

    public IPais Pais { get; set; }

    // Es un algoritmo que tienen distintas implementaciones
    // en este caso, una por pais.
    // Esta solucion no cumple con OCP!!
    public int CalcularImpuestos()
    {
        return Pais.CalcularImpuestos(this);
    }
}