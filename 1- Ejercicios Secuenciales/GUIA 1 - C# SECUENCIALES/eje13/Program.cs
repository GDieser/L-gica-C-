using System;

namespace eje13
{
    /*Hacer un programa para un cajero automático para ingresar un importe a retirar y 
     * convertir el mismo en la cantidad de billetes de $1.000, $500, $200 y $100 a entregar.
    Ejemplo A: Si el importe a retirar es $2500 se mostrará por pantalla que se deberán 
    entregar 2 billetes de $1.000, 1 billete de $500,  0 billetes de $200 y 0 billetes de $100.
    Ejemplo B: Si el importe a retirar es $3400 se mostrará por pantalla que se deberán 
    entregar 3 billetes de $1.000, 2 billetes de $200, 0 billetes de $500 y 0 billetes de $100.
    Ejemplo C: Si el importe a retirar es $300 se mostrará por pantalla que se deberán 
    entregar 1 billete de $200, 1 billete de $100, 0 billetes de $1.000 y 0 billetes de $500.
    Recordatorio. Considerar en todos los casos que el importe a retirar es en todos 
    los casos múltiplo de $100 ya que el cajero no cuenta con billetes de $50, $20 o $10.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int importe, resto1, resto2, billeteC, billeteQ, billeteM;

            Console.WriteLine("Ingrese monto a retirar: ");
            importe = int.Parse(Console.ReadLine());

            resto1 = importe % 1000;
            resto2 = resto1 % 500;

            billeteC = resto2 / 100;
            billeteQ = (resto1 - resto2) / 500;
            billeteM = (importe - resto1) / 1000;

            Console.WriteLine("Se entregan: " + billeteM + " billete/s de $1000, " + billeteQ + " billete/s de $500 y " + billeteC + " billete/s de $100");

            Console.ReadKey();

        }
    }
}
