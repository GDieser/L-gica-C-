using System;

namespace ej33
{
    class Program
    {
        static void Main(string[] args)
        {
        // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo 
        // o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
        // Informar el promedio teniendo en cuenta sólo los números primos.
    	
        int n1, cont = 0, acu = 0;

        Console.WriteLine("Ingrese un numero: ");
        n1 = int.Parse(Console.ReadLine());

        while (n1 != 0)
        {
            if(primos(n1)){
                cont++;
                acu+=n1;
            }
            
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El promedio de los primos es: "+ (acu/cont));

        }

        static bool primos(int a){

            int cont = 0;

            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                    cont++;
                
            }

            if(cont == 2)
                return true;
            else
                return false;
        }
    }
}
