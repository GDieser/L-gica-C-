using System;

namespace ej44
{
    class Program
    {
        static void Main(string[] args)
        {
        // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que 
        // reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida 
        // por referencia con:

        // a. 1 si el número es positivo.
        // b. -1 si el número es negativo.
        // c. 0 si el número es cero.

        // int n1, n2 = 0;

        // Console.WriteLine("Ingrese un numero: ");
        // n1 = int.Parse(Console.ReadLine());

        // positivoNegativoCero(n1, ref n2);

        // Console.WriteLine("El estado del numero: " + n1 +" es: "+n2);

        int n1, n2, n3, n4;

        Console.WriteLine("Ingrese un numero : ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero : ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero : ");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero : ");
        n4 = int.Parse(Console.ReadLine());

        if (n1 > n2 && n2 > n3 && n3> n4)
        {
            Console.WriteLine("N1 + n2 es mayor");
            
        }


        }

        // static void positivoNegativoCero(int numero, ref int estado){

        //     if(numero > 0)
        //         estado = 1;
        //     else if(numero < 0)
        //         estado = -1;
        //     else    
        //         estado = 0;
        // }
    }
}
