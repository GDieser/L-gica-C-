using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si 
            //el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y 
            //por sí mismo.
            
            int x, n1, cont = 0;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            for (x = 1; x <= n1; x++){
                
                if((n1%x) == 0)
                cont++;
            }
            if(cont == 2)
                Console.WriteLine("El numero es primo");
            else
                Console.WriteLine("El numero no es primo");
        }
    }
}
