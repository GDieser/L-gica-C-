using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y 
            //emitir un cartel aclaratorio si la suma de los dos
            //primeros es mayor al producto del segundo con el tercero.

            float n1, n2, n3, suma, producto;

            Console.WriteLine("Ingrese un numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el 3er numero: ");
            n3 = float.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n2 * n3;

            if(suma > producto)
                Console.WriteLine("La suma es mayor que le producto");
            else
                Console.WriteLine("El producto es mayor que la suma");  
        }
    }
}
