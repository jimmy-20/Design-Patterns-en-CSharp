# Patrones de diseño
Los patrones de diseño son soluciones probadas y comprobadas a problemas comunes que se encuentran en el desarrollo de software. Estos patrones proporcionan una forma estructurada y organizada de abordar el diseño y la implementación de software, lo que puede mejorar la calidad del código, hacer que el software sea más fácil de mantener y reducir los costos de desarrollo.
![UML Clases](https://raw.githubusercontent.com/jimmy-20/Design-Patterns-en-CSharp/master/Images/UML%20Photo.jpg)

# Problemática
Imaginemos que realizamos un CRUD de las clases Producto, Cliente y Personas, cada uno tiene sus respectivos método para crear, visualizar, actualizar y eliminar.  Pero que pasaría si ahora queremos agregar mas clases como puede ser Proveedores, Compras e inclusive Pagos, tendriamos que acoplar y realizar el debido CRUD a cada clase. Hay que tomar en cuenta que todas estas tienen como común las operaciones antes mencionadas y hacer esto de nuevo, puede ser demasiado ineficiente en términos de reutilización de código, ¿porque no usar POO, para que, al momento de agregar una nueva clase, solamente lo acoplemos y herede de una clase abstracta que tenga estas operaciones?. Este escenario es una posible solución para evitar realizar código desde 0, en esto consiste estos patrones de diseños, brindar soluciones a problemáticas que ya surgieron en el pasado para implementarlas en nuestro contexto.

## Tabla de contenido

- [¿Que es un patrón de diseño?](#Definicion).
- [¿Para que nos sirven?](#Funcion).
- [Críticas de los patrones de diseño](#Critica).
- [Clasificación de los patrones de diseño](#Clasificacion).
. [Experiencia propia](#Experiencia)
## ¿Qué es un patrón de diseño? <a name = "Definicion"></a>
>“Cada patrón describe un problema que ocurre una y otra vez en nuestro entorno, y luego describe el núcleo de la solución a ese problema de tal manera que puedas usar esta solución un millón de veces, sin hacerlo nunca de la misma manera dos veces” - _Cristopher Alexander_

A menudo los patrones se confunden con algoritmos, porque ambos conceptos describen soluciones típicas a problemas conocidos. Mientras que un algoritmo siempre define un grupo claro de acciones para lograr un objetivo, un patrón es una descripción de más alto nivel de una solución
## ¿Para que nos sirven? <a name = "Funcion"></a>
Cuando empezamos a desarrollar software, es común que cada quien utilice su propia lógica, conocimientos y experiencia para crear código. Y esto muchas veces resulta en desarrollos complejos que sólo su creador entiende.

Un patrón de diseño debe cumplir al menos tres objetivos:
1. Estandarizar el lenguaje entre programadores
2. Evitar perder el tiempo en soluciones ya existentes
3. Crear código reusable.

## Críticas de los patrones de diseño <a name="Critica"></a>
>Chapuzas para un lenguaje de programación débil.

>Soluciones ineficientes.

>Uso injustificado: Si  lo único que tienes es un martillo, todo te parecerá un clavo.

Uno de los principales problemas que surgen de los principantes al conocer estos patrones, es que deseen aplicarlos en todas partes. Aunque pueden ser muy útiles, no se tienen que tomar todo muy al pie de la letra, sino acoplarlo, integrarlo e implementarlo en el contexto en el que te encuentres, ya que puede existir la posibilidad que haciendo un código simple, sea la respuesta a lo que buscas.
## Clasificación de los patrones de diseño <a name="Clasificacion"></a>
Los patrones de diseño varían en su complejidad, nivel de detalle y escala de aplicabilidad, entre los cuales tenemos.
1. Patrones creacionales: Proporcionan mecanismos de creación de objetos que incrementan la flexibilidad y la reutilización de código existente.
2. Patrones estructurales, explican cómo ensamblar objetos y clases en estructuras más grandes a la vez que se mantiene la flexibilidad y eficiencia de la estructura.
3. Patrones de comportamiento: Se encargan de una comunicación efectiva y la asignación de responsabilidades entre objetos.

# Experiencia propia <a name='Experiencia'></a>
En mis inicios en la programación, tenia una sensación de lo que realizaba se puede hacer de una mejor forma, aunque para esos entonces no supe como, mientras mas escribía, más codigo engorroso realizaba, al tal punto de hacía la tradicional.
~~~
Ctrl+C Para Copiar
Ctrl+V Para Pegar donde era igual.
~~~
Y luego ocurria lo horrible, lo fatídico, me salian errores, bugs, cosas muy raras que por ende, tenia que modificar y a su vez, borrar todo ese pedazo de código y volver a pegar el nuevo ya modificiado y sucesivamente. 😥

El primer patrón que aprendi fue el "Factory Pattern" o el patrón de fábrica, y también, suelo usarlo en los escenarios donde necesitaba cambiar de manera dinámica, un panel principal y me funcionó de maravilla, aunque por supuesto no fue 100% efectivo, si me ahorró mucho trabajo en optimizar la aplicación, debido a que para cambiar, tendía a instanciar una y otra vez los formularios si percatarme del aumento de RAM que llevaba eso.

Suerte en sus futuros proyectos y espero que este artículo te haya aportado un valor agregado en tus conocimientos. 😉.
