using System;

namespace eje16
{
    /*Hacer un programa para ingresar por teclado las cuatro notas de los exámenes
    obtenidas por un alumno y luego emitir uno solo de los cartel de acuerdo a las
    siguientes condiciones:
    - “Promociona”, sí obtuvo en los cuatro exámenes nota 7 o más.
    - “Rinde examen final”, si obtuvo nota 4 o más en por lo menos tres exámenes.
    - “Recupera Parciales”, si obtuvo nota 4 o más en por lo menos uno de los
    exámenes.
    - “Recursa la materia”, si no aprobó ningún examen parcial.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, contSiete = 0, contCuatro = 0;

            Console.WriteLine("Ingrese la primera nota: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cuarta nota: ");
            num4 = int.Parse(Console.ReadLine());

            if (num1 >= 7)
            {
                contSiete++;
                contCuatro++;
            }
            else
            {
                if (num1 >= 4)
                {
                    contCuatro++;
                }
            }
            if (num2 >= 7)
            {
                contSiete++;
                contCuatro++;
            }
            else
            {
                if (num2 >= 4)
                {
                    contCuatro++;
                }
            }
            if (num3 >= 7)
            {
                contSiete++;
                contCuatro++;
            }
            else
            {
                if (num3 >= 4)
                {
                    contCuatro++;
                }
            }
            if (num4 >= 7)
            {
                contSiete++;
                contCuatro++;
            }
            else
            {
                if (num4 >= 4)
                {
                    contCuatro++;
                }
            }

            if (contSiete == 4)
            {
                Console.WriteLine("El alumno promociona =D");
            }
            else
            {
                if (contCuatro >= 3)
                {
                    Console.WriteLine("El alumno rinde examen Final =S");
                }
                else
                {
                    if (contCuatro >= 1)
                    {
                        Console.WriteLine("El alumno rescupera Parcial =S");
                    }
                    else
                    {
                        Console.WriteLine("El alumno recursa la materia =(");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
