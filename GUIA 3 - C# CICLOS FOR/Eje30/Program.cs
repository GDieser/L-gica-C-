using System;

namespace Eje30
{
    /*Dada una lista de 7 números todos distintos entre sí determinar e informar con un
    cartel aclaratorio si los números primos ingresados en la misma están ordenados de menor
    a mayor. Los números primos pueden no ser consecutivos, pero sí estar ordenados.

    Ejemplo A: 4, 5, 7, 12, 13, 19, 20. Se emite un cartel que diga “Ordenados” ya que los
    números primos están ordenados: 5, 7, 13, 19.

    Ejemplo B: 4, 10, 3, 5, 11, 7, 14. Se emite un cartel que diga “Desordenados” ya
    que los números primos no están ordenados: 3, 5, 11, 7.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, num, cont1 = 0, cont2 = 0, cont3 = 0, primoMayor = 0;

            for (x = 0; x < 7; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                for (y = 1; y <= num; y++)
                {

                    if (num % y == 0)
                    {
                        cont1++;
                    }
                }
                if (cont1 == 2 && cont2 == 0)
                {
                    primoMayor = num;
                    cont2++;
                }

                if (cont1 == 2)
                {
                    cont3++;
                    if (num > primoMayor)
                    {
                        primoMayor = num;
                        cont2++;
                    }
                }

                cont1 = 0;
            }

            if (cont2 == cont3)
            {
                Console.WriteLine("Ordenado!!!");
            }
            else
            {
                Console.WriteLine("Desordenado...");
            }
        }
    }
}
