using System;

namespace Eje6
{
    /* Hacer un programa para ingresar un N valor que indica la cantidad de números que componen una
    lista y luego solicitar se ingresen esos N números. Se pide informar cuantos son positivos
    Ejemplo A: Se ingresa como N el valor 5, y luego se ingresa: 10, -3, 2, 5, 4. Se listará:  Cantidad
    de Positivos: 4
    Ejemplo B: Se ingresa como N el valor 6, y luego se ingresa: -10, -3, -2, 0, -5, -4. Se listará:
    Cantidad de Positivos: 0
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, cantidad, num1, contador = 0;

            Console.WriteLine("Ingrese cantidad de numero que componen la lista: ");
            cantidad = int.Parse(Console.ReadLine());

            for (x = 0; x < cantidad; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());

                if (num1 > 0)
                {
                    contador++;
                }
            }

            Console.WriteLine("La cantidad de numeros positivos es: " + contador);
            
            Console.ReadKey();
        }
    }
}
