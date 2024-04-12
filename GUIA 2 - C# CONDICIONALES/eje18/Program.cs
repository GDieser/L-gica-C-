using System;

namespace eje18
{
    /*Una empresa de electricidad cobra el servicio a sus clientes de acuerdo a la
    siguiente escala:
    $10 por kilovatio (kW) por el consumo hasta los primeros 100 kW de consumo.
    $12 por kW por el consumo excedente de 101 a 200 kW.
    $15 por kW por el consumo excedente de 201 kW en adelante.
    Hacer un programa para que, dado el consumo en kilovatios de un determinado
    cliente, el programa calcule e informe el total a pagar.
    Ejemplo 1: Un consumo de 55 kW, se calculará: $ 10 x 55= $ 550
    Ejemplo 2: Un consumo de 125 kW, se calculará: $10 x 100 + $12 x 25 = $1300.
    Ejemplo 3: Un consumo de 250 kW, se calculará: $10 x 100 + $12 x 100 + $15 x
    50 = $2950*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int consumo, total, resto1, resto2;

            Console.WriteLine("Ingrese el consumo: ");
            consumo = int.Parse(Console.ReadLine());

            if (consumo <= 100)
            {
                total = consumo * 10;
            }
            else
            {
                if (consumo <= 200)
                {

                    resto1 = consumo % 100;
                    resto2 = consumo - resto1;
                    total = (resto2 * 10) + (resto1 * 12);
                }
                else
                {
                    resto1 = consumo - 200;
                    total = (100 * 10) + (100 * 12) + (resto1 * 15);
                }
            }
            Console.WriteLine("El total a pagar por el consumo mensual es: $" + total);

            Console.ReadKey();
        }
    }
}
