using System;

namespace Eje22
{
    /*Dada una lista de 7 números informar el primer número par ingresado y su
    ubicación en la lista y el último de los números primos y su ubicación en la lista.
    Ejemplo A: 7, 4, 5, 6, 9, 13, 10 se informa:
    Primer número par: 4 ubicación 2. Último primo: 13 ubicación 6.
    Ejemplo B: 9, 5, 21, 9, 13, 15, 6 se informa:
    Primer número par: 6 ubicación 7. Último primo: 13 ubicación 5
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, num, par = 0, primo = 0, ubicacion = 0, ubicacion2 = 0, contador = 0;

            for (x = 1; x <= 7; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num%2 == 0 && ubicacion == 0)
                {
                    par = num;
                    ubicacion = x;
                }

                for (y = 1; y <= num; y++)
                {
                    if (num % y == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    primo = num;
                    ubicacion2 = x;
                    contador = 0;
                }
                else
                {
                    contador = 0;
                }
            }

            Console.WriteLine("El primer par ingresado es: " + par + " en la ubicacion: " + ubicacion);

            Console.WriteLine("El ultimo primo ingresado es: " + primo + " en la ubicacion: " + ubicacion2);

            Console.ReadKey();
        }
    }
}
