// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a ; 
int b ; 

a = 10 ;
b = a ;

Console.WriteLine("Valor de a: " +a );
Console.WriteLine("Valor de a: " +b );

int intNum1= 0;
bool bandera = false;
string? numString = "";

while (!bandera)
{
    Console.WriteLine("Ingrese un numero válido");
    numString = Console.ReadLine();
    bandera = int.TryParse(numString, out intNum1);
    if (!bandera) {
        Console.WriteLine(numString + " no es numero válido.");   
    }

}

int aux;
int resto;
int cantDigitos = 0;
double invertido = 0;
aux = intNum1;

 while(aux != 0){             
    aux = aux/10;         
    cantDigitos++;      
}

aux = intNum1;

if (intNum1 > 0 )
{
    while (aux != 0)
    {
        resto = aux % 10;
        invertido += resto * Math.Pow(10,cantDigitos-1);
        aux = aux / 10;
        cantDigitos = cantDigitos - 1;
    }
}

Console.WriteLine("El numero invertido es: " + invertido);*/

    int operacion, repetir = 1;

    while (repetir == 1)
    {
    Console.WriteLine("\nDesea realizar operaciones de un numero o de dos?(1 o 2):");
    string eleccion = Console.ReadLine();
    if (int.TryParse(eleccion, out int seleccion) && 0 < seleccion && seleccion < 3)
    {
        // -- Calculadora 1 --
        if (seleccion == 2)
        {
            // Pido que introduzcan dos enteros
            Console.WriteLine("\nIngrese el primer numero: ");
            string numero1 = Console.ReadLine();
            Console.WriteLine("\nIngrese el segundo numero: ");
            string numero2 = Console.ReadLine();

            // Compruebo si lo introducido son enteros, si lo son, creo variables de tipo entero con los datos
            if (int.TryParse(numero1, out int num1) && int.TryParse(numero2, out int num2))
            {
                // Pido que introduzca el tipo de operacion que quiere realizar:
                Console.WriteLine("\nSELECCIONE LA OPERACION : \n 1:SUMAR \n 2:RESTAR \n 3:MULTIPLICAR \n 4:DIVIDIR");
                string entrada = Console.ReadLine();

                // Compruebo que el numero de operacion sea entero
                if (int.TryParse(entrada, out operacion) && 0 < operacion && operacion < 5)
                {

                    // Hago un switch con las operaciones
                    switch (operacion)
                    {
                        case 1:
                            Console.WriteLine($"\nSuma: {num1 + num2}\n");
                            break;
                        case 2:
                            Console.WriteLine($"\nResta: {num1 - num2}\n");
                            break;
                        case 3:
                            Console.WriteLine($"\nMultiplicacion: {num1 * num2}\n");
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                Console.WriteLine("\nNo se puede dividir por 0\n");
                            }
                            else
                            {
                                Console.WriteLine($"\nDivision: {num1 / num2}\n");
                            }
                            break;
                    }
                    // Determinar el mayor y el menor de los números
                    Console.WriteLine($"El numero mayor entre {num1} y {num2} es {Math.Max(num1, num2)}");
                    Console.WriteLine($"El numero menor entre {num1} y {num2} es: {Math.Min(num1, num2)}");
                }
                else
                {
                    Console.WriteLine("\nNo se ingreso una operacion valida\n");
                }
            }
            else
            {
                Console.WriteLine("\nLos numeros ingresados deben ser enteros\n");
            }

        // -- Calculadora 2--
        } else if (seleccion == 1) {
            Console.WriteLine("\nIntroduzca el numero: ");
            string numeral1 = Console.ReadLine();

            // Compruebo si lo introducido es un entero, si es asi, creo una variable con el dato
            if (float.TryParse(numeral1, out float nume1)) {
                Console.WriteLine("\nSELECCIONE OPERACION: \n1:VALOR ABSOLUTO\n2:CUADRADO\n3:RAIZ CUADRADA\n4:SENO\n5:COSENO\n6:PARTE ENTERA DE UN DECIMAL");
                string entradav2 = Console.ReadLine();
                if (int.TryParse(entradav2, out operacion) && 0 < operacion && operacion < 7) {

                    // Hago un Switch con las operaciones
                    switch(operacion) {
                    case 1:
                        Console.WriteLine($"\nValor absoluto: {Math.Abs(nume1)}");
                    break;
                    case 2:
                        Console.WriteLine($"\nCuadrado: {Math.Pow(nume1, 2)}");
                    break;
                    case 3:
                        if (nume1 < 0) {
                            Console.WriteLine("\nNo existen raices cuadradas de numeros negativos en los Reales\n");
                        } else {
                            Console.WriteLine($"\nRaiz cuadrada: {Math.Sqrt(nume1)}");
                        }
                    break;
                    case 4:
                        Console.WriteLine($"\nSeno: {Math.Sin(nume1)}");
                    break;
                    case 5:
                        Console.WriteLine($"\nCoseno de {nume1}: {Math.Cos(nume1)}");
                    break;
                    case 6:
                        Console.WriteLine($"\nParte entera de {nume1}: {Math.Truncate(nume1)}");
                    break;
                }
                } else {
                    Console.WriteLine("El dato introducido no corresponde con una operacion disponible");
                }

                            
            } else {
                Console.WriteLine("El dato introducido no es un entero");
            }
        }
    }
    else
    {
        Console.WriteLine("\n---El dato introducido no es valido (1 o 2)---\n");
    }

    // Consulto si desea realizar otra operacion
    Console.WriteLine("Desea realizar otra operacion? (1 = si, 0 = no)\n");
    string answer = Console.ReadLine();
    int.TryParse(answer, out int respuesta);
    repetir = respuesta;
}
