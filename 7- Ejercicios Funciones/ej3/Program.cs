using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
        // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo 
        // o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
        // Informar el promedio teniendo en cuenta sólo los números primos.

        int n1, contTotal = 0, contPrimo = 0, acu = 0, primo1, promedio;

        Console.WriteLine("Ingresa un numero: ");
        n1 = int.Parse(Console.ReadLine());

        while (n1 != 0)
        {       
            contTotal++;
            primo1 = primo(n1);

            // Console.WriteLine("primo1 " +primo1);

            if(primo1 == 1){
                contPrimo++;
                acu += n1;
            }

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());


        }

        promedio = acu / contPrimo;

        Console.WriteLine("El promedio de numeros primos es: "+promedio);


        }

        static int primo(int a){

            int primo = 0, cont = 0;

            for (int x = 1; x <= a; x++)
            {
                if((a % x) == 0){
                    cont++;
                }
                
            }
            if(cont == 2)
                primo = 1;

            return primo;


        }
    }
}
