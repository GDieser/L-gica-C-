using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {

            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los 
            //números pares y el mínimo de los números impares
            
            int x, n1, max = 0, min = 0;
            int conPar = 0, conImpar = 0;

            for (x = 0; x < 6; x++){
                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());
 
                if((n1%2) == 0){
                    conPar++
                    if(conPar == 0)
                        max = n1;
                    else if (n1 > max)
                        max = n1;
                }else{
                    conImpar++
                    if(conImpar == 0)
                        min = n1;
                    else if (n1 < min)
                        min = n1;
            }
            Console.WriteLine("Minimo impar: "+min);
            Console.WriteLine("Maximo par: "+max);
        }
    }
}
