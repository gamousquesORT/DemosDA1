# Ejemplo de aplicación de OCP #
Este ejemplo muestra paso a paso como aplicar el principio de Open/Closed Principle (OCP) a una clase FileImporter.


### Problema ###
Tenemos que importar archivos del tipo CSV y TXT y sabemos que a futuro se van a agregar nuevos tipos archivos a importar.

### Solución ###
__ImportarSinOCPPaso1__ - está todo implementado en una sola clase FileImporter con dos métodos, uno para cada tipo de archivo.
No es una buena solución porque cualquier cambio implica cambiar la clase FileImporter.
La clase FileImporter No cumple OCP porque hay que modificarla para agregar un nuevo tipo de importador.

__ImportarSinOCPPaso2__ - Se refactorea extrayendo dos clases una para importar txt y otra para importar csv. 
El método Import de la clase FileImporter mantien el IF para llamar al método correspondiente de la clase importadora correspondiente.

No es una buena solución porque cualquier cambio implica cambiar el IF en el método Import de FileImporter.
La clase FileImporter No cumple OCP porque hay que modificarla para agregar un nuevo tipo de importador.

__ImportarConPolimorfismoPaso3__ - Se refactorea extrayendo una clase abstracta Importer y dos clases que la implementan y hacen override del método Import
Este método recibe el importador el cual es creado en la Program 

Esta solución permite agregar nuevos importadores sin tocar la clase FileImporter, la cual cumple con el principio de OCP.
Por ejemplo en el Program se agregó un importador de tipo XML el cual se injecta en la clase ImportFile sin tocar la clase FileImporter.

Esta solución hace que la clase FileImporter cumpla con el principio de OCP.