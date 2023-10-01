namespace ToRefactorExamples;

/* - Cambiar todos los Nombres no significativos a significativos.
 * - Utilizar la convención de C# de programación y en Ingles
 * - Refactoree y aplique Clean Code en todo el código
 *      ->reemplazar números magicos
 *       ->reemplazar comentarios por nombres significativos
 *       -> extraer métodos
 * 
 */
public class operations_on_numbers
{
    private int total;
    private int contador;

    public operations_on_numbers()
    {
        total = 0;
        contador = 0;
    }
    
    public int magic_function(List<int> ns)
    {
        foreach (int n in ns)
        {
            if (n % 2 == 0)
            {
                total += n;
                contador++;
            }
        }

        if (contador == 0)
        {
            throw new Exception("La lista no contiene numeros pares  ");
        }
        else
        {
            return total / contador;
        }
    }
}

    
