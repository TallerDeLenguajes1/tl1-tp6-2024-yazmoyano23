## Trabajando con el tipo string 

### ¿String es una tipo por valor o un tipo por referencia?

String es un tipo por referencia, dependiendo el contexto su comportamiento puede parecerse al tipo por valor porque no puede modificarse despues de su creacion. Cada vez que se "modifica" una cadena, en realidad se crea una nueva instancia de la cadena y se cambia la referencia para apuntar a esta nueva instancia.

### ¿Qué secuencias de escape tiene el tipo string?

**\\** - Barra invertida (\): Para insertar una barra invertida en una cadena
**\n** - Nueva línea (line feed): Inserta un salto de linea
**\r** - Carriage return : Retorna el cursor al principio de la línea sin avanzar a la siguiente línea.
**\t** - Tabulador horizontal:mInserta un tabulador horizontal en la cadena.
**\b** - Retroceso (backspace): Mueve el cursor una posición hacia atrás.
**\v** - Tabulador vertical: Inserta un tabulador vertical (similar a una nueva línea pero con un salto mayor).
**\'** - Comilla simple ('): Se utiliza para insertar una comilla simple en una cadena.

**\"** - Comilla doble ("): Se utiliza para insertar una comilla doble en una cadena.

**\0** - Nulo (\0): Representa el carácter nulo (valor ASCII 0).

###¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

El carácter @ convierte una cadena en una cadena verbatim, esto es:
- Ignora las secuencias de escape: Las barras invertidas (\) se tratan como caracteres literales y no como el inicio de una secuencia de escape.
- Mantiene el formato del texto: Las nuevas líneas, tabulaciones y otros espacios en blanco se mantienen tal como están escritos en el código.

El carácter $ permite utilizar interpolación de cadenas. Esto significa que puedes insertar expresiones dentro de una cadena, y estas se evaluarán y formatearán como parte de la cadena. Es util para mostrar mensajes y variables por pantalla.
Para insertar una expresión, se utiliza ${expresión} dentro de la cadena.

Ejemplo:
```
string nombre = "Juan";
int edad = 30;
string mensaje = $"Mi nombre es {nombre} y tengo {edad} años.";
```