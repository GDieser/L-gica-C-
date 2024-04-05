using System;

namespace ej4
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
        
        int n1 = 0, resultado = 0;

        positivoNegativoCero(ref n1);

        //resultado = referencia(n1);

        Console.WriteLine("Resultado: "+n1);

        }
        // static int referencia(int a){
             
        //     int n2; 

        //     if (a == 0){    
        //         n2 = 0;
        //     }else if(a > 0){
        //         n2 = 1;
        //     }else{
        //         n2 = -1;
        //     }

        //     return n2;
        // }

        static void positivoNegativoCero(ref int n1){

        Console.WriteLine("Ingrese un nro: ");
        n1 = int.Parse(Console.ReadLine());

         if (n1 == 0){    
                n1 = 0;
            }else if(n1 > 0){
                n1 = 1;
            }else{
                n1 = -1;
            }

        }

    }
}
