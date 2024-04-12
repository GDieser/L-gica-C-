using System;

namespace eje14
{
    /*Hacer un programa para ingresar por teclado la fecha de nacimiento de una
    persona, ingresando día, mes y año como 3 datos individuales. Luego ingresar
    la fecha actual ingresando día, mes y año como 3 datos individuales. Calcular
    luego la edad en años de esa persona y listar por pantalla.
    Ejemplo 1. Si se ingresa como fecha de nacimiento: 3/12/2000 y la fecha actual
    es 26/2/2019 la edad de esa persona es 18 ya que los 19 recién los cumple en
    diciembre.
    Ejemplo 2. Si se ingresa como fecha de nacimiento: 3/1/2000 y la fecha actual
    es 26/2/2019 la edad de esa persona es 19.
    Ejemplo 3. Si se ingresa como fecha de nacimiento: 28/2/2000 y la fecha actual
    es 26/2/2019 la edad de esa persona es 18 ya que le faltan 2 días para cumplir
    los 19 años.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaNac, mesNac, anioNac, diaAct, mesAct, AnioAct, anios;

            Console.WriteLine("Ingrese dia de su fecha de nacimiento: ");
            diaNac = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese mes de su fecha de nacimiento: ");
            mesNac = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese anio de su fecha de nacimiento: ");
            anioNac = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese dia actual: ");
            diaAct = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese mes actual: ");
            mesAct = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese anio actual: ");
            AnioAct = int.Parse(Console.ReadLine());

            anios = AnioAct - anioNac;

            if (mesAct > mesNac)
            {
                Console.WriteLine("La persona tiene: " + anios + " anios");
            }
            else
            {
                if (mesAct == mesNac)
                {
                    if (diaAct == diaNac || diaAct > diaNac)
                    {
                        Console.WriteLine("La persona tiene: " + anios + " anios");
                    }
                    else
                    {
                        anios--;
                        Console.WriteLine("La persona tiene: " + anios + " anios");
                    }
                }
                else
                {
                    anios--;
                    Console.WriteLine("La persona tiene: " + anios + " anios");
                }
            }

            Console.ReadKey();
        }
    }
}
