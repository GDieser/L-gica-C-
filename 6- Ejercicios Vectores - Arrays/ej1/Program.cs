using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
        //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int[] n1  = new int[10];
        int n2, con = 1, max = 0, posi = 0;

        for (int x = 0; x < 10; x++){

            Console.WriteLine("Ingrese un numero: ");
            n2 = int.Parse(Console.ReadLine());

            n1[x] = n2;

            if(n2 > max){
                max = n2;
                posi = con;
            }
            con++;
            }
            
            Console.WriteLine("El valor mayor es: "+ max +" ubicado en la posicion: "+ posi);

        }
    }
}
