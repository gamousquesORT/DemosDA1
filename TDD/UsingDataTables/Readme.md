# Ejemplo de uso de DataRows en los test #
En algunos casos al escribir test unitarios nos encontramos que para probar un método, que retorna un resultado dependiendo de combinaciones de valores, necesitamos escribir una serie de test en los cuales solo varían los valores de entrada. En estos casos podemos utilizar DataRows para simplificar la escritura de los test.

Este ejemplo muestra un caso hipotético en el cual tenemos un clase Deposit que calcula su precio en función de:

- la cantidad de días que se alquila el mismo.
- si tiene refrigeración
- si tiene una promoción asociada, etc.
    
    
En caso de cumplir las condiciones debe retornar el precio correcto.

En caso de no cumplir las condiciones debe retornar un excepción con un mensaje correcto.

En este ejemplo mostramos ambos casos utilizando dataRows. 

Tenga en cuenta que __verificar el texto__ de una excepción __no es una buena práctica__, pero en este caso se hace para mostrar como se puede hacer.

**AVISO: El código de producción aun no esta Refactoreado, ya que al escribirlo seguí la recomendación de ir creando el arnés de prueba para poder refactorear con seguridad.**

Es una buen ejercicio de refactorización para el lector.

