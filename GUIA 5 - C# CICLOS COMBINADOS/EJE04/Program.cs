using System;

namespace EJE04
{
    /*4
    Dada una lista de números compuesta por 10 grupos y cada grupo separado del siguiente por un cero, 
    se pide determinar e informar:

    a) Para cada uno de los grupos el máximo de los números pares y el máximo de los números impares. 
    Se informan 2 resultados por cada grupo.
    b) Para cada uno de los grupos el porcentaje de números negativos y números positivos. 
    Se informan 2 resultados por cada grupo.
    c) Cuántos números positivos había en total entre los 10 grupos. Se informa 1 resultado al final.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contadorPositivos = 0, contadorTotalPositivos = 0, porcentajeNegativos, porcentajePositivos, maximoPares = 0, maximoImpares = 0, contadorTotales = 0;
            bool maxPares = true, maxImpares = true;

            for (int i = 0; i < 2; i++)
            {

                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                
                while (numero != 0)
                {
                    //A)
                    if (numero%2 == 0)
                    {
                        if (maxPares == true || numero > maximoPares)
                        {
                            maximoPares = numero;
                            maxPares = false;
                        }
                    }
                    else
                    {
                        if (maxImpares == true || numero > maximoImpares)
                        {
                            maximoImpares = numero;
                            maxImpares = false;
                        }
                    }

                    //B)
                    contadorTotales++;

                    if (numero > 0)
                    {
                        contadorPositivos++;
                        contadorTotalPositivos++;
                    }

                    Console.WriteLine();
                    Console.Write("Ingrese un número: ");
                    numero = int.Parse(Console.ReadLine());
                }
                
                Console.WriteLine();
                //A)
                Console.WriteLine("El maximo de los número pares es: " + maximoPares + " y el maximo de los números impares es: " + maximoImpares);

                //B)
                porcentajePositivos = (contadorPositivos * 100) / contadorTotales;
                porcentajeNegativos = 100 - porcentajePositivos;

                Console.WriteLine();
                Console.WriteLine("El porcentaje de número positivos: " + porcentajePositivos + "%, y el porcentaje de números negativos: " + porcentajeNegativos + "%");


                maxImpares = maxPares = true;
                maximoImpares = maximoPares = contadorTotales = contadorPositivos = 0;
            }
            
            //C)
            Console.WriteLine();
            Console.WriteLine("Se ingresaron: " + contadorTotalPositivos + " de número positivos.");
            Console.ReadKey();  
        }
    }
}
