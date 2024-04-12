using System;

namespace eje2
{
    /*Hacer un programa que solicite por teclado que se ingresen dos 
      números y luego guardarlos
    en dos variables distintas. A continuación se deben intercambiar 
    mutuamente los valores en ambas
    variables y mostrarlos por pantalla.
    Ejemplo: Suponiendo que se ingresan 3 y 8 como valores y que 
    la variables usadas son A y B, entonces A=3 y B=8,
    pero luego debe quedar A=8 y B=3.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("Los valores invertidos son: " + num1 + " y " + num2);

            Console.ReadKey();

        }
    }
}
