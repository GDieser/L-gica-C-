using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
        //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
        //Solo se debe emitir UN valor por pantalla.

        int x, n1, mayor = 0;

        for (x = 1; x <= 10 ; x++){
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (x == 1)
                mayor = n1;

            else{
                if( n1 > mayor)
                    mayor = n1;
                }
            }

            Console.WriteLine("El numero mayor es: " + mayor);
        
        }
    }
}
