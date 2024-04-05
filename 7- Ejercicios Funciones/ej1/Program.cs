using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
        //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el 
        // producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y 
        // muestre por pantalla el monto total a pagar. Usar la función.

            int n1, n2, total;

            Console.WriteLine("Ingrese el precio del Art.: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad comprada: ");
            n2 = int.Parse(Console.ReadLine());

            total = producto(n1, n2);


            Console.WriteLine("El monto total a pagar es: " + total);

        }

        static int producto(int a, int b){

            int producto;

            producto = a * b;

            return producto;

        }
    }
}
