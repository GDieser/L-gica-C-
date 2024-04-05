using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
        // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n1, resto, cont = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());

                resto = par(n1);

                if(resto == 1){
                    cont++;
                }

            }

            if(cont == 0)
                Console.WriteLine("No hay numeros pares...");
            else
                Console.WriteLine("La cantidad de numero pares es: "+cont);

        }

        static int par(int a){

            int par = 0;

            if((a % 2) == 0){
                par = 1;
            }else{
                par = 0;
            }

            return par;

        }
    }
}
