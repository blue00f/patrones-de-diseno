# 🎨 Patrones de Diseño

Este repositorio contiene los trabajos prácticos y material de estudio sobre **Patrones de Diseño**, correspondientes a la asignatura de Ingeniería de Software.
El contenido abarca los patrones clásicos del catálogo GOF (*Gang of Four*), organizados en dos tandas de estudio, junto con ejemplos de aplicación en C#.

---

## 🎯 Objetivo

Comprender y aplicar los Patrones de Diseño GOF (Creacionales, Estructurales y de Comportamiento) como soluciones reutilizables a problemas recurrentes del diseño orientado a objetos, favoreciendo el desacoplamiento, la extensibilidad y el mantenimiento del software.

---

## 📚 Contenido del Programa

### 🔹 Patrones de Diseño I

**Patrones de creación**

- **Singleton.** Introducción y desarrollo para garantizar que una clase tenga solo una instancia y proporcionar un punto de acceso global a la misma.
- **Abstract Factory.** Introducción y desarrollo para proporcionar una interfaz que permita crear familias de objetos relacionados o que dependan entre sí, sin especificar sus clases concretas.
- **Factory Method.** Introducción y desarrollo para definir una interfaz que permite crear un objeto, dejando que sean las subclases quienes decidan qué clase instanciar. Delegación de la creación de objetos de una clase en sus subclases.

**Patrones estructurales**

- **Adapter.** Introducción y desarrollo para convertir la interfaz de una clase en otra, que es la que esperan los clientes. Colaboración entre clases que poseen interfaces incompatibles.
- **Composite.** Introducción y desarrollo para componer objetos en forma de árbol para representar jerarquías del tipo parte–todo.
- **Decorator.** Introducción y desarrollo para asignar responsabilidades adicionales a un objeto dinámicamente. Extensión de las funcionalidades sin utilizar herencia.

**Patrones de comportamiento**

- **Interpreter.** Introducción y desarrollo para lograr que, dado un lenguaje, se pueda definir una representación de su gramática junto con un intérprete.
- **Iterator.** Introducción y desarrollo para proporcionar un modo de acceder secuencialmente a los elementos de un objeto agregado sin exponer su representación interna.
- **Mediator.** Introducción y desarrollo para definir un objeto que encapsula cómo interactúan una serie de objetos.
- **Memento.** Introducción y desarrollo para recordar, representar y externalizar el estado de un objeto sin violar la encapsulación. Retorno a un estado anterior.
- **Observer.** Introducción y desarrollo para definir una dependencia de uno a muchos entre objetos. Notificación de cambio de estado entre objetos dependientes.

---

### 🔹 Patrones de Diseño II

**Patrones de creación**

- **Builder.** Introducción y desarrollo para separar la construcción de un objeto complejo de su representación, de forma que el mismo proceso de construcción permita crear diferentes representaciones.
- **Prototype.** Introducción y desarrollo para establecer la especificación de los tipos de objetos a crear por medio de una instancia prototípica. Creación de nuevos objetos copiando el prototipo.

**Patrones estructurales**

- **Bridge.** Introducción y desarrollo para poder desacoplar una abstracción de su implementación, de forma que ambas puedan variar de forma independiente.
- **Facade.** Introducción y desarrollo para proporcionar una interfaz unificada para un conjunto de interfaces de un subsistema. Construcción de interfaces de alto nivel para facilitar el uso del sistema.
- **Flyweight.** Introducción y desarrollo para obtener pequeños objetos compartidos utilizables en distintos contextos.
- **Proxy.** Introducción y desarrollo para generar una estructura que presente un objeto sustituto o "representante" para acceder al objeto principal.

**Patrones de comportamiento**

- **Chain of Responsibility.** Introducción y desarrollo para evitar acoplar el emisor de una petición a su receptor. Cómo lograr una estructura de comportamiento que permita a más de un objeto responder a una misma petición.
- **Command.** Introducción y desarrollo para encapsular una petición en un objeto. Parametrización de peticiones encapsuladas en objetos. Establecimiento de colas y registro de peticiones.
- **State.** Introducción y desarrollo para lograr que un objeto cambie su comportamiento cada vez que cambie su estado interno.
- **Strategy.** Introducción y desarrollo para definir una familia de algoritmos, cada uno de ellos encapsulado e intercambiable.
- **Template Method.** Introducción y desarrollo para la delegación en subclases de algunos pasos de un algoritmo sin cambiar la estructura de este.
- **Visitor.** Introducción y desarrollo para definir nuevas operaciones sin cambiar las clases de los elementos sobre los que opera. Concepto de Refactorización.
