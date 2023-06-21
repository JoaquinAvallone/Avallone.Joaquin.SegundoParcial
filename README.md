# La Generala
### Segundo Parcial Labo 2     
**Nombre:** Avallone Joaquin

## Consigna:
Desarrollar un simulador de juegos de mesa.
Para lo cual quiere, por esta vez, que desarrollemos uno de los siguientes juegos:

● Truco.
● La generala.
● Uno.
● La escoba de 15.
● Chinchón.

La aplicación deberá simular partidas en tiempo real. Es decir, el usuario que corra la aplicación
deberá poder crear salas de juego donde se jugarán las partidas de forma simultánea.
Mientras las partidas se están jugando, el usuario de la aplicación deberá poder consultar en cada
una de ellas:
● La información de la partida seleccionada.
● Ver las estadísticas del historial de partidas jugadas.
● Mover el formulario por toda la pantalla sin que la partida se vea afectada.
● Cancelar la partida en curso.

Las partidas deberán tener las siguientes caracteristicas:
1) Serán partidas cortas, es decir, no hace falta que la partida sea extensa.
Por ejemplo:

● Si el desarrollador elige desarrollar el truco, la partida deberá simular 4 rondas
(manos).
● Si el jugador elige La Generala, deberán ser simuladas las primeras 4 tiradas de
dados de cada uno de los jugadores (pueden ser 2 o 4).

2) Las partidas podrán crearse en cualquier momento de la ejecución del programa, no hay
restricción de cantidad de salas abiertas. Las partidas pueden o no terminar juntas.

Una vez finalizada la partida, deberá notificarse en un nuevo formulario quien fue el ganador de la
partida y toda la información de la misma.
Si los desarrolladores lo desean,una vez terminada la funcionalidad que simula las partidas, los
desarrolladores podrán hacer otro modo de juego. Esto último será opcional.

## Descripción
La Generala es una aplicacion que permite la creación de un usuario con el cual podras jugar diferentes partidas de generala en simultaneo, cuanto con un modo de juego automatizado y otro de Player vs. Player.
El usuario tambien puede acceder a un historial donde se podran ver los datos de las partidas jugadas guardados en una base de datos.

## Desarrallo de las partidas:
**PC VS PC:** Este modo de juego se realiza de forma automatica. Consiste en 8 tiradas de 5 dados por cada jugador las cuales se van ejecutando cada cierto tiempo respetando los turnos de cada uno. Al terminar todas las tiradas el sistema
las recorrera de una en una evaluando si se logro realizar alguna jugada especial (Escalera, Full, Poker, Generala) y asignandole los puntos correspondientas a cada tirada. De no ser una jugada especial verificara el dado mas repetido 
y asignara los puntos correspondientes a ese numero. Cuando termine de analizar todas las tiradas de cada jugador, se calcularan los puntos totales de cada uno y se abrira un nuevo formulario anunciando al ganador.

**PLAYER VS PLAYER:** En este modo de juego el usuario podra jugar contra otra persona. En este modo de juego se podra jugar una partida completa donde cada jugador tendra 3 tiros de 5 dados por turno donde podra seleccionar con que dados quedarse,
 tirando solo los dados no seleccionados en su siguiente tiro. Una vez que el jugador se queda sin tiros tendra la libertad de elegir a que juego o numero asignarle los puntos. Una vez que ambos jugadores se quedan sin juegos o numeros a los
cuales asignarle puntos, el juego terminara abriendose un formulario que anuncie al ganador.

##Juego LogIn
Con lo primero que nos encontraremos al abrir la app sera con el LogIn, en donde en caso de estar registrado podras pon3er tu nombre de usuario y contraseña y acceder a la pantalla principal de La Generala.


[![Captura-de-pantalla-2023-06-20-215111.png](https://i.postimg.cc/DzBpCtN6/Captura-de-pantalla-2023-06-20-215111.png)](https://postimg.cc/LqgV502g)

De ser un usuario nuevo tendras que clickear el boton de registrarse en el cual tendras que rellenar todos tus datos, una vez hecho esto te llevara directamente a la pantalla principal.
Una vez te registres tus datos se guardaran en la base de datos de SQL permitiendo al usuario volver a ingresar a la app cuando quiera sin perder sus registros.


[![Captura-de-pantalla-2023-06-20-215121.png](https://i.postimg.cc/KckFMNKw/Captura-de-pantalla-2023-06-20-215121.png)](https://postimg.cc/jCbGVy44)

Una vez nos encontremos en la pantalla principal nos encontraremos con dos modos de juego distintos y el historial de nuestras partidas:


[![Captura-de-pantalla-2023-06-20-215207.png](https://i.postimg.cc/SKkNLM08/Captura-de-pantalla-2023-06-20-215207.png)](https://postimg.cc/RWpB4qZV)

Aca podras creear tu partida de Player Vs Player donde el jugador uno sera el usuario que ingreso a la app y el jugador dos podra seleccionar entre los distintos jugadores genericos de la app.


[![Captura-de-pantalla-2023-06-20-220702.png](https://i.postimg.cc/RCk36q01/Captura-de-pantalla-2023-06-20-220702.png)](https://postimg.cc/dD9QgsrD)

Una vez creada la partida se abrira el juego. El primer turno es del usuario en el que trendra que apretar el boton tirar y se moveran los dados del medio, trendra 3 tiradas por turno pudiendo seleccionar con que dados quedarse y a que juego o numero
otorgarle los puntos.


[![Captura-de-pantalla-2023-06-20-215312.png](https://i.postimg.cc/kGKgFF5Q/Captura-de-pantalla-2023-06-20-215312.png)](https://postimg.cc/30rh3GmN)

[![Captura-de-pantalla-2023-06-20-215343.png](https://i.postimg.cc/ZR6Gwfr5/Captura-de-pantalla-2023-06-20-215343.png)](https://postimg.cc/5YNK0S7h)

Luego de terminar con nuestras tres tiradas y haber seleccionado a que juego otorgarle puntos tendremos que apretar el boton Pasar turno, el cual nos asignara los puntos y dejera jugar al segundo jugador el cual podra realizar las mismas acciones

[![Captura-de-pantalla-2023-06-20-215354.png](https://i.postimg.cc/FFWZ2yDr/Captura-de-pantalla-2023-06-20-215354.png)](https://postimg.cc/LhPLPZcw)

Tambien se pueden creear de la misma forma partidas automatizadas donde el jugador uno sera el usuario y de la misma forma que el modo de juego anterior, el jugador dos podra seleccionarse entre los jugadores del sistema.

[![Captura-de-pantalla-2023-06-20-215225.png](https://i.postimg.cc/DZYXYgFR/Captura-de-pantalla-2023-06-20-215225.png)](https://postimg.cc/zbKvyTyk)

Una vez creada la partida se abrira el juego automatizado en el cual se realizaran 8 turnos de una tirada por cada uno por cada jugador

[![Captura-de-pantalla-2023-06-20-215422.png](https://i.postimg.cc/L6jTQnQv/Captura-de-pantalla-2023-06-20-215422.png)](https://postimg.cc/mt2Ct2sF)

Una vez finalizadas todas las partidas que quiera el usuario, ya sean una en una o en simultaneo, podra acceder al historial para verificar cuantas partidas gano y cuantas perdio.
Tambien puede cancelar las partidas, ya sea cerrandolas o apretando el boton cancelar antes de que terminen, y estas no apareceran en el historial

[![Captura-de-pantalla-2023-06-20-215240.png](https://i.postimg.cc/vmKfZsSc/Captura-de-pantalla-2023-06-20-215240.png)](https://postimg.cc/p9DpsgvH)

## Diagrama de Clases:

[![Captura-de-pantalla-2023-06-20-192628.png](https://i.postimg.cc/fW8ZtRf2/Captura-de-pantalla-2023-06-20-192628.png)](https://postimg.cc/8sfxxD3M)


