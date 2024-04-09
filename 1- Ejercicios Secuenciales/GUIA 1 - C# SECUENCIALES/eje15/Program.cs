using System;

namespace eje15
{
    /*La amplitud térmica es la diferencia entre la temperatura máxima y la temperatura 
     * mínima en una zona y tiempo determinado. Dada la temperatura máxima y la temperatura 
     * mínima de San Fernando de ayer, calcular y mostrar la amplitud térmica.
    NOTA: El usuario ingresará como temperatura máxima un valor mayor o igual al de la 
    temperatura mínima.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo, maximo, amplitud;

            Console.WriteLine("Ingrese la temperatura mayor: ");
            maximo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la temperatura menor: ");
            minimo = int.Parse(Console.ReadLine());

            amplitud = maximo - minimo;

            Console.WriteLine("La amplitud termica es: " + amplitud + " C");

            Console.ReadKey();
        }
    }
}
