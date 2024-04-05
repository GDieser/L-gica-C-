using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //0: Declarar variable
            //tipos: int, float, char, bool
            int n1, n2, resultado;

            //1: Pedir valores
            Console.WriteLine("Ingrese un Numero:");
            
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro Numero:");
            
            n2 = int.Parse(Console.ReadLine());
            
            //2: Realizar calculo  

            resultado = n1 + n2;

            //3: Emitir resultado

            Console.WriteLine("El reusltados es: "+ resultado);
        }
    }
}
