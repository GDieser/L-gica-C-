using System;

namespace eje12
{
    /*Hacer un programa para leer tres números diferentes y determinar e informar el
    número del medio.
    Sugerimos probar CADA UNA de las siguientes 6 combinaciones.
    N1=8, N2=6, N3=10. Valor del medio: 8. N1=8, N2=10, N3=6. Valor del medio: 8
    N1=6, N2=8, N3=10. Valor del medio: 8. N1=10, N2=8, N3=6. Valor del medio: 8
    N1=6, N2=10, N3=8. Valor del medio: 8. N1=10, N2=6, N3=8. Valor del medio: 8*/
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
            }
            else
            {
                if (c < menor)
                {
                    medio = menor;
                }
                else
                {
                    medio = c;
                }
            }

            Console.WriteLine("El valor medio es: " + medio);

            Console.ReadKey();
        }
    }
}
