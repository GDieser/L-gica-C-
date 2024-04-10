using System;
using System.Runtime.ConstrainedExecution;

namespace eje13
{
    /*Hacer un programa para ingresar tres números distintos y listarlos ordenados
    de menor a mayor.
    Sugerimos probar CADA UNA de las siguientes 6 combinaciones.
    Si N1=8, N2=6, N3=10 ó N1=8, N2=10, N3=6. Se muestra: 6, 8, 10.
    Si N1=6, N2=8, N3=10 ó N1=10, N2=8, N3=6. Se muestra: 6, 8, 10.
    Si N1=6, N2=10, N3=8 ó N1=10, N2=6, N3=8. Se muestra: 6, 8, 10.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, mayor, menor, medio;

            Console.WriteLine("Ingrese un primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer numero: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                mayor = a;
                menor = b;
            }
            else
            {
                mayor = b;
                menor = a;
            }

            if (c > mayor)
            {
                medio = mayor;
                mayor = c;
            }
            else
            {
                if (c < menor)
                {
                    medio = menor;
                    menor = c;
                }
                else
                {
                    medio = c;
                }
            }

            Console.WriteLine("-------------");
            Console.WriteLine("-MENOR : " + menor);
            Console.WriteLine("-MEDIO : " + medio);
            Console.WriteLine("-MAYOR : " + mayor);
            Console.WriteLine("-------------");

            Console.ReadKey();

        }
    }
}
