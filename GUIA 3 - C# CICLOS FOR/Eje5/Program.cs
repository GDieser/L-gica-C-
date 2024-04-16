using System;

namespace Eje5
{
    /*Hacer un programa para que el usuario ingrese dos números y luego el programa muestre por
    pantalla los números entre el menor y el mayor de ambos.
    Ejemplo, si el usuario ingresa 3 y 15, se mostrarán los números entre el 3 y el 15 y si el
    usuario ingresa 25 y 8, se mostrarán los números entre el 8 y el 25.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num1, num2, menor, mayor;

            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                menor = num1;
                mayor = num2;
            }
            else
            {
                menor = num2;
                mayor = num1;
            }

            Console.WriteLine("Numero mayor: " + mayor);

            Console.WriteLine("Numero menor: " + menor);

            for (x = menor; x <= mayor; x++)
            {

                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
