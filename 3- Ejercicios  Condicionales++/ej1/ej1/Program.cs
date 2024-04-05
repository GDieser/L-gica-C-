using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos 
            //números y luego calcular:

            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el 
            //resultado correspondiente.

            float n1, n2, resultado;

            Console.WriteLine("Ingrese un numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Los numero son: "+n1+" y "+n2);

            if(n1 == n2)
                resultado = n1 + n2;
               // Console.WriteLine("El resultado es: "+resultado);
            else if(n1 > n2)
                resultado = n1 - n2;
                //Console.WriteLine("El resultado es: "+resultado);
            else
                resultado = n1 * n2;
                
                
            Console.WriteLine("El resultado es: "+resultado);

            

        }
    }
}
