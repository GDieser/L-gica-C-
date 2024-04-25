using System;

namespace Eje28
{
    /*La cuenta corriente de la famosa cantante Lady Lara ha registrado 14 movimientos
    durante la semana pasada. Por cada movimiento se registró:
    Número de movimiento
    Día
    Tipo ('E' - Extracción / 'D' - Depósito)
    Importe

    Existe un registro por movimiento. Se desea calcular e informar:
    El saldo final de la cuenta.
    El porcentaje de movimientos de extracción y el porcentaje de depósito.
    El depósito de mayor importe indicando también día y número de movimiento.
    La cantidad de movimientos del día 10.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, dia, total = 0, numMovimiento, diaMayor = 0, contE = 0, contD = 0, numMayor = 0, contD10 = 0, porcentaje1, porcentaje2;
            float importe, acumE = 0, acumD = 0, depositoMayor = 0, saldoFinal;
            char tipo;

            for (x = 1; x <= 15; x++)
            {

                Console.WriteLine("Ingrese Numero de movimiento: ");
                numMovimiento = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Dia: ");
                dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese tipo de operacion: 'E'-Extraccion o 'D'-Deposito...");
                tipo = char.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese importe: ");
                importe = int.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 'e':
                        acumE += importe;
                        contE++;
                        break;
                    case 'd':
                        acumD += importe;
                        contD++;

                        if (importe > depositoMayor)
                        {
                            depositoMayor = importe;
                            diaMayor = dia;
                            numMayor = numMovimiento;

                        }
                        break;
                }

                if (dia == 10)
                {
                    contD10++;
                }

            }
            total = contE + contD;

            porcentaje1 = (contE * 100) / total;
            porcentaje2 = (contD * 100) / total;

            saldoFinal = acumD - acumE;

            Console.WriteLine("Saldo final: $" + saldoFinal);

            Console.WriteLine("Porcentaje de Deposito: " + porcentaje2 + "%, porcenjae de Extracciones: " + porcentaje1 + "% ");

            Console.WriteLine("Deposito maximo: " + depositoMayor + ", realizado el dia: " + diaMayor + ", numero de movimiento: " + numMayor);

            Console.WriteLine("Cantidad de movimientos del dia 10: " + contD10);
        }
    }
}
