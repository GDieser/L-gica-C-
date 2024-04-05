using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. 
            //Luego analizar e informar por pantalla si los 
            //mismos se encuentran ordenados de forma decreciente .

            float n1, n2, n3, n4;

            Console.WriteLine("Ingrese el primer numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            n3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero: ");
            n4 = float.Parse(Console.ReadLine());

            if(n1 > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("Los numeros ingresados estan ord. de forma decreciente");   
            }else{
                Console.WriteLine("Los numeros ingresados NO estan ord. de forma decreciente");
            }

        }
    }
}
