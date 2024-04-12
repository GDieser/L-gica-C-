using System;

namespace eje11
{
    internal class Program
    {
     /*Hacer un programa para ingresar cinco números y listar cuantos de esos cinco
     números son positivos, cuantos son negativos y cuantos son iguales a 0.*/
        static void Main(string[] args)
        {
            int a, b, c, d, e, positivo = 0, negativo = 0, cero = 0;

            Console.WriteLine("Ingrese un primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer numero: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un cuarto numero: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un quinto numero: ");
            e = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                positivo++;
            }
            else
            {
                if (a < 0)
                {
                    negativo++;
                }
                else
                {
                    cero++;
                }
            }
            if (b > 0)
            {
                positivo++;
            }
            else
            {
                if (b < 0)
                {
                    negativo++;
                }
                else
                {
                    cero++;
                }
            }
            if (c > 0)
            {
                positivo++;
            }
            else
            {
                if (c < 0)
                {
                    negativo++;
                }
                else
                {
                    cero++;
                }
            }
            if (d > 0)
            {
                positivo++;
            }
            else
            {
                if (d < 0)
                {
                    negativo++;
                }
                else
                {
                    cero++;
                }
            }
            if (e > 0)
            {
                positivo++;
            }
            else
            {
                if (e < 0)
                {
                    negativo++;
                }
                else
                {
                    cero++;
                }
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("-POSITIVOS : " + positivo);
            Console.WriteLine("-NEGATIVOS : " + negativo);
            Console.WriteLine("-CEROS     : " + cero);
            Console.WriteLine("-----------------");

            Console.ReadKey();
        }
    }
}
