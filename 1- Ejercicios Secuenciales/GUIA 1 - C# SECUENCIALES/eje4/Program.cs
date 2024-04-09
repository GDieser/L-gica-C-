using System;

namespace eje4
{
    /*Hacer un programa para ingresar por teclado la cantidad de asientos totales en un avión
    y la cantidad de pasajes ocupados y luego calcular e informar el porcentaje de ocupación y
    el porcentaje de no ocupación del mismo.
    Ejemplo si el avión tiene 200 asientos totales y se vendieron 80 pasajes, el porcentaje de
    ocupación que se informará será de un 40% y el porcentaje de no ocupación será de un 60%.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int asientosTotales, asientosOcupados, porOcupado, porNoVendido;

            Console.WriteLine("Ingrese la cantidad total de asientos: ");
            asientosTotales = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de asientos ocupados: ");
            asientosOcupados = int.Parse(Console.ReadLine());

            porOcupado = (asientosOcupados * 100) / asientosTotales;
            porNoVendido = 100 - porOcupado;

            Console.WriteLine("Porcentaje de ocupacion: " + porOcupado + "%");

            Console.WriteLine("Porcentaje no ocupado: " + porNoVendido + "%");
        }
    }
}
