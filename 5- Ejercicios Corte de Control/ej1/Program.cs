using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y 
            //mostrar por pantalla cuántos de esos números son primos.

            int x, y, n1, total = 0;

            //Console.WriteLine("Ingrese u numero: ");
            //n1 = int.Parse(Console.ReadLines());

            for (x = 0; x < 10; x++){
                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());

                int cont = 0;

                for (y = 1; y <= n1; y++){
                    if(n1%y == 0)
                        cont++;
                    }
                    if(cont == 2){
                        total++;
                        Console.WriteLine("Primo");
                }
            }
            Console.WriteLine("La cantidad de primos son: "+total);
        }
    }
}
