﻿using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero:");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("La suma da: " +resultado);


        }
    }
}
