# Introducción

Este proyecto consiste en la implementación de la lógica de un videojuego llamado Hunt the Wumpus, En el juego, el jugador se mueve a través de una serie de cuevas conectadas, dispuestas como los vértices de un dodecaedro, mientras cazan a un monstruo llamado el Wumpus.
Asimismo, se hace uso de autómatas y expresiones utilizadas en .NET, la mayoría del proyecto fue escrita en F#, aunque también se puede hacer uso de una que otra sintaxis de C#.
Este proyecto se desarrolló en equipo para la materia de Teoría Computacional, para el diseño del juego y de los diccionarios y estructuras de datos, ya existían algunas variaciones e implementaciones en Python, por lo que se tuvo que traducir en unas ocasiones, y en otras, por falta de código o información exterior, se tenía que idear en equipo alguna solución para resolver el algoritmo.
Al hacer uso de F#, se involucran tipos de datos y funciones que son generalizadas de manera automática y son inferidas al momento de ejecutar el código. Se aplican conocimientos y principios básicos sobre máquinas de Turing, Teoría de Complejidad Avanzada y un poco acerca del uso de expresiones regulares. 
Para ejecutar el juego: El juego es autónomo en un solo archivo. Debe tener instalado el intérprete de .NET en el sistema. 
Para ejecutar, se debe abrir una ventana de línea de comandos y escriba: dotnet run dentro de la carpeta donde se encuentra el archivo; Si todo funciona bien, estará disfrutando de juegos basados en TTY de computadora vintage.

 

# Antecedentes
Hunt The Wumpus fue creado por Gregory Yob en 1973 después de ver algunos de los juegos de escondite distribuidos por People's Computer Company. Juegos como Hurkle, Snark y Mugwump se basaban en una cuadrícula de 10x10 usando coordenadas cartesianas, pero Yob pensó que podía crear un juego más interesante sin usar un sistema de cuadrícula y lo lanzó a través del PCC. En la versión original del juego, el sistema de cuevas era un dodecaedro regular y cada vértice representaba una habitación.
Decidimos hacer este proyecto porque, consideramos que las condiciones para recorrer el sistema de cuevas y ganar el juego puede ser resuelto a partir de una máquina de estados, la cual se implementó por medio de los métodos del programa. Es un reto desafiante al mismo tiempo que lograble para un acercamiento a la aplicación de estas en un ambiente más cotidiano, lo que nos impulsó a la realización del programa.

# Metodología
 
La metodología utilizada para la realización de nuestro proyecto fue primeramente desarrollar el juego en nuestro entorno de trabajo, el cual sería fsharp. El código fuente del juego fue liberado hace ya bastante tiempo, lo que nos simplifico un poco esta tarea, aunque se debió adaptar el proyecto para los objetivos que deseábamos obtener.
Una vez desarrollado el juego, se debía transformar las condiciones de victoria y fracaso dentro del juego a la máquina de estados que permitiría la resolución del reto presentado por el juego. Parte de las modificaciones inicialmente implementadas al juego es que, en vez de ser mapas generados aleatoriamente, se trabajó con un solo nivel diseñado estáticamente el cual nos permitiría mantener más control sobre el funcionamiento de la maquina y el nivel de satisfacción respecto al modo de juego resultado de la implementación. Se realizaron múltiples iteraciones de desarrollo y testeo, con el fin de obtener los resultados esperados, principalmente el de lograr la victoria en el juego.

# Desarrollo
El desarrollo del sistema se realizó en dos fases distintas. La primera fase consistió en recrear el videojuego de “Kill The Wumpus” en fsharp. Y la segunda fase, en implementar el método para moverse automáticamente.
En la primera parte, primero se comenzó realizando la esquematización del mapa. La característica de este es que es un arreglo de 4 x 4, el cual se tiene que visualizar en la pantalla, para saber por dónde nos estamos moviendo. La idea es que, se muestre cada recuadro con un signo de pregunta y que, al avanzar, se quite el signo y se despliegue el sensor en la parte superior.
 
Posteriormente, se crearon los métodos y funciones para poder moverse dentro del arreglo y también para contar cuando caigamos en un pit o entremos en una zona donde se encontraba el wumpus. Cada una de estas funciones tiene un funcionamiento crucial en el juego y además permite tener un control preciso sobre cuando termina o no el juego. A continuación, se muestra una descripción de las funciones creadas:
- grabGold() – Función que permite agarrar el oro y que cambia el sensor, para que ya no sea detectado.
- wumpusKilled() – Función que, al acertarte al wumpus, activa la variable de que fue matado y además, permite que el wumpus ya no sea detectado.
- uncover() – Función para imprimir los sensores dentro del mapa. Como tal, esta función solo sirve como apoyo al jugador para saber cuál fue el sensor que le salió en los distintos cuartos del mapa.
- visited() – Método que mantiene un historial de las casillas visitadas y sin repetirse.
- checkSensor() – Función que devuelve una cadena con el sensor para la ubicación actual del agente.
- generateProps() – Inicialmente, este método generaba el mapa de manera aleatoria. El problema de la auto implementación es que existen muchos caminos, por lo cual, son casi infinitas las decisiones. Por ello, se optó por declarar un solo mapa posible con los objetos definidos.
Por otro lado, para poder ejecutar el juego, se necesitó de una función principal, la cual mandara a llamar todo lo anterior. Este fue el caso de moveBetween(). Al inicio de esta sentencia, se describe la coordenada actual y se manda a llamar a la función generateProps(). Seguido, se tiene un while de control con la función isGameOver, lo que hace un control para saber cuándo se termina el juego.
En caso de que el juego siga, se imprime la ventana del juego con todos los componentes que anteriormente se mostraron. Una vez mostrado, se pide la entrada por teclado para poder moverse dentro del juego. Esta parte se encuentra validada, por lo que no puedes realizar movimientos que no corresponden. Finalmente, después de que se haya introducido algo y sea realizado, se valida que la posición actual no coincida con los pits o wumpus, ya que, en ese caso, se pierde el juego. La otra posibilidad es que la posición actual sea igual a la inicial y se tenga la barra de oro, si se cumple, se gana el juego.
En general, eso es todo lo que comprende el juego implementado en el ambiente de fsharp, así que aquí termina la primera fase de implementación. La fase 2, comprendió la implementación de dos funciones y la modificación de la fase 1 para su adaptación.
Para comenzar, el primer método realizado fue probabilityMatrix(), la cual tiene un trasfondo de toma de decisiones. Cómo tal, genera una matriz de probabilidades, la cual es de tres dimensiones. En la dimensión X y Y, se encarga de las posiciones del arreglo (4 x 2), y en la dimensión Z, se encarga de guardar una probabilidad de que en cierta posición haya un pit, wumpus u oro. Al moverse alrededor de las casillas, se generarán las probabilidades dentro de la matriz, las cuales podrán ser vistan en la pantalla de salida. A continuación, se muestra la matriz, la cual muestra por donde es muy posible que haya un pozo. Por otro lado, se ven posiciones en “-1”, lo cual menciona que la posibilidad de que haya algo en esa posición es nula.
 
La segunda función tomo de referencia esta matriz para ir generando los movimientos en el juego. El algoritmo consiste en que cuando no hubo colisión en X, se mueve a:
- La derecha cuando no hay peligro en esa dirección o cuando la posibilidad de que haya un pozo a la izquierda o abajo es grande.
- Arriba cuando la posibilidad de un pozo a la derecha es grande.
- Izquierda cuando no hay peligro en esa dirección. En este caso, se activa la variable de colisión, ya que, si regresa a la izquierda es porque ya no pudo ir a la derecha.
- En el caso de que haya una colisión, se mueve a:
- Arriba cuando en la posición de arriba no hay peligro o cuando la posibilidad de que haya un pozo abajo es muy grande.
- En caso de estar en una posición diferente a tres:
	- Se mueve arriba si abajo hay una posibilidad muy grande de un pozo.
	- Se mueve a la izquierda en caso contrario
- Izquierda en caso predeterminado.
Si ocurre una excepción de un índice, aprovecha para checar si en la posición actual esta el oro. Si sí esta, lo agarra. Si no, sigue avanzando.
En caso de encontrar y agarrar el oro, sigue con la parte final, regresar a la posición inicial. Para ello, se recorre un arreglo con el historial de las posiciones y se va comparando la posición actual con lo que hay en el historial. En caso de que una posición no coincida, se salta. Esto hace que el recorrido final pueda ser más rápido y corto.
Cómo tal, en esta parte termina la fase 2. Lo único por hacer es que en lugar de que el usuario le dé el comando, que sea la función de autoMove(). Para esto, se le pasa la variable con los comandos generados a la parte que hace la comparación. Y para ejecutar los comandos generados, es necesario dar enter para que se vaya realizando de uno por uno.
 
# Conclusiones
Realizar este Proyecto fue divertido y aunque nos tomó varias horas, se pudo lograr con éxito la ejecución del juego. 
Asimismo, se describe en el desarrollo que por limitantes de complejidad y de tiempo, las variaciones en el algoritmo se redujeron a una para el camino. 
Existen varias oportunidades de mejora del proyecto, siempre hay una forma de hacer que el código sea más eficiente en complejidad computacional.
En el caso de nuestro proyecto, se cuenta con una matriz aleatoria, es similar al problema de Tic Tac Toe, pero con algunas reglas diferentes. Se cumple que el problema es NP.
 
