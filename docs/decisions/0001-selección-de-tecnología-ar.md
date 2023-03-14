# Selección de tecnología AR

* Status: proposed
* Date: 2023-03-14

## Context and Problem Statement

En el curso de Arquitectura de software necesitamos enseñar el uso de tácticas y mecanismos de arquitectura. A su vez, nos interesa aportar a los estudiantes la oportunidad de aprender un nuevo lenguaje de programación que esté comenzando a popularizar en la industria.

## Decision Drivers

* El tiempo de aprendizaje de un nuevo lenguaje por parte del estudiante
* El  ecosistema asociado al lenguaje sea lo suficientemente rico como para utilizar en el obligatorio
* El valor que agrega al estudiante para su incorporación en la industria

## Considered Options

* NodeJS
* GoLang

## Decision Outcome

Chosen option: "NodeJS", because Hoy no podemos invertir en cambiar todo el material

### Positive Consequences

* Seguimos usando un lenguaje popular
* No tiene alta curva de aprendizaje para los estudiantes

### Negative Consequences

* No estamos dando la oportunidad de que aprendan un lenguaje nuevo y en asenso 


## Pros and Cons of the Options

### NodeJS

* Good, because Ya tenemos el curso armando
* Good, because Tiene un ecosistema extremadamente popular
* Good, because JavaScript se utiliza tanto en FE como BE
* Bad, because No promueve buenas prácticas de programación
* Bad, because Algunas tácticas de arquitectura como de las de performance no son fáciles de implementar

### GoLang

* Good, because Lenguaje simple
* Good, because Promueve el uso de buenas prácticas de desarrollo
* Good, because Tiene un ecosistema creciente
* Good, because Se está empezando a popularizar en  arq. distribuidas y en cloud
* Bad, because El costo de migrar todo el material es alto
* Bad, because No todos los docentes tienen tiempo de pasarse a Go
