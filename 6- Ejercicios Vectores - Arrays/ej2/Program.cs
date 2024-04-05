using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
        //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        int[] n1 = new int[10];
        int n2, acu = 0, promedio;

            for (int x = 0; x < 10; x++){
                Console.WriteLine("Numero: ");
                n2 = int.Parse(Console.ReadLine());
                n1[x] = n2;

                acu += n2;
            }
            promedio = acu/10;
            Console.WriteLine("El promedio es: "+promedio);
                
            for (int y = 0; y < 10; y++){
                if(n1[y] > promedio){
                    Console.WriteLine("El numero: " + n1[y] + " es mayor que el promedio: "+ promedio);
                }
            }


        }
    }
}
