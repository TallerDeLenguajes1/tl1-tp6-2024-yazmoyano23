// See https://aka.ms/new-console-template for more information
using System.Globalization;
/*
Console.WriteLine("Hello, World!");

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

Console.WriteLine("El numero invertido es: " + invertido);

/*
Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.


*/
    do
    {   
       
        Console.WriteLine("\nSELECCIONE LA OPERACION : \n 1:SUMAR \n 2:RESTAR \n 3:MULTIPLICAR \n 4:DIVIDIR");

        do
        {          
            Console.WriteLine("\nIngresar opcion:");
            entrada = Console.ReadLine();                
        } while (!int.TryParse(entrada, out operacion) || (operacion != 1 && operacion!= 2 && operacion != 3 && operacion != 4 && operacion != 5) );
        

            do
            {
                Console.WriteLine("\nIngrese el primer numero:");
                N1 = Console.ReadLine(); 
            } while (!float.TryParse(N1, out Num1));

            do
            {
                Console.WriteLine("\nIngrese el segundo numero:");
                N2 = Console.ReadLine(); 
            } while (!float.TryParse(N2, out Num2));

           switch (operacion)
           {
                case 1: // CONTROL DE SUMA
                    Console.WriteLine("\nEl resultado de la suma es: " + (Num1 + Num2));
                    break;
                
                case 2: // CONTROL DE RESTA
                    Console.WriteLine("\nEl resultado de la resta es: " + (Num1 - Num2));
                    break;

                case 3: // CONTROL DE MULTIPLICACIÓN
                    Console.WriteLine("\nEl resultado de la multiplicación es: " + (Num1 * Num2));
                    break;

                case 4: // CONTROL DE DIVISIÓN
                    if (Num2 != 0) 
                    {
                        Console.WriteLine("\nEl resultado de la división es: " + (Num1 / Num2));
                    } 
                    else 
                    {
                        Console.WriteLine("\nNo se puede dividir entre 0");
                    }
                    break;

                default:
                    Console.WriteLine("\nOperación no válida");
                    break;
            }
                salir = true;

        } else {
            salir = false;
        }

    } while (salir);


 