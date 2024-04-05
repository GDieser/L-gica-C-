using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas 
            //personas mayores a 18 años.
            
            int x, n1, mayores1 = 0, mayores2 = 0, promedio;

            for (x = 0; x < 20; x++){

                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());

                if(n1 > 18){
                    mayores1 = n1 + mayores1;
                    //mayores1 += n1;
                    mayores2++;
                }
                
            }
            //Console.WriteLine("Mayores1 " +mayores1);
            //Console.WriteLine("Mayores2 " +mayores2);
            promedio = mayores1/mayores2;
            Console.WriteLine("El promedio de los mayores de edad es: "+promedio);

        }
    }
}
