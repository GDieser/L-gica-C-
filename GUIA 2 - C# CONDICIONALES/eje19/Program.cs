using System;

namespace eje19
{
    /*Este ejercicio lo resolverán en la parte práctica de la materia.
    El costo de un desarrollo de un proyecto de software se calcula en base al
    lenguaje que se necesita:

    -------------------------------
    |NOMBRE |  TIPO |  VALOR HORA |
    -------------------------------
    |C/C++  |  'C'  |    $7500    |
    |C#     |  '#'  |    $6100    |
    |PYHTON |  'P'  |    $5400    |
    |GO     |  'G'  |    $5000    |
    -------------------------------

    Además, si el proyecto es marcado como Urgente, se le aumenta un 120 % más
    al costo del proyecto.
    Le solicitan un programa que permita calcular el costo total de un proyecto
    basado en la cantidad de horas (int), el tipo de lenguaje (char) y si es urgente o
    no (bool)
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            float hora, importe = 0, u = 0;
            char l;
            bool urgente = u == 1;

            Console.WriteLine("------------------------------- ");
            Console.WriteLine("|NOMBRE |  TIPO |  VALOR HORA | ");
            Console.WriteLine("------------------------------- ");
            Console.WriteLine("|C/C++  |  'C'  |    $7500    | ");
            Console.WriteLine("|C#     |  '#'  |    $6100    | ");
            Console.WriteLine("|PYHTON |  'P'  |    $5400    | ");
            Console.WriteLine("|GO     |  'G'  |    $5000    | ");
            Console.WriteLine("------------------------------- ");

            Console.WriteLine("Elija el tipo de lenguaje segun tipos: 'C', '#', 'P', 'G'");
            l = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de horas: ");
            hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Es urgente? 1-SI | 0-NO ");
            u = int.Parse(Console.ReadLine());


            switch (l)
            {
                case 'c':
                case 'C':
                    importe = hora * 7500;
                    break;
                case '#':
                    importe = hora * 6100;
                    break;
                case 'p':
                case 'P':
                    importe = hora * 5400;
                    break;
                case 'g':
                case 'G':
                    importe = hora * 5000;
                    break;
            }

            if (urgente)
            {
                importe = importe * 2.2f;
            }

            Console.WriteLine("El valor a abonar es: $" + importe);

            Console.ReadKey();
        }
    }
}
