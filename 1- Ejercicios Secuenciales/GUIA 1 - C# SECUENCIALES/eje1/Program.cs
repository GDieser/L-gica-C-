using System;

namespace eje1
{
    /*Hacer un programa para ingresar por teclado la cantidad de 
     * horas trabajadas por un operario
    y el valor que se le paga por hora trabajada y listar por pantalla 
    el sueldo que le corresponda.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, valorSueldo, total;

            Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor por hora: ");
            valorSueldo = int.Parse(Console.ReadLine());

            total = horas * valorSueldo;

            Console.WriteLine("El sueldo a pagar es: $" + total);

            Console.ReadKey();
        }
    }
}
