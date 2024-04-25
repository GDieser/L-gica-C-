using System;

namespace Eje27
{
    /*Una estación meteorológica registró una muestra climática de los últimos 15 días.
     Por cada día registró:
    Número de día (entero)
    Temperatura (float)
    Milímetros de lluvia (float)
    Visibilidad en km (float)

    Hay un registro por cada día. La información se encuentra ordenada por día.
    Se pide calcular e informar:
    El número del día que se haya registrado la temperatura máxima.
    La amplitud térmica de todo el período.
    La cantidad de días con neblina.
    Mostrar "Quincena lluviosa" si hubo más días de lluvia que días sin lluvia.
    Mostrar "Quincena húmeda" si llovió en al menos un tercio de los días. De lo
    contrario mostrar "Quincena seca".

    NOTA: La amplitud térmica es la diferencia entre la temperatura máxima y la
    temperatura mínima.
    NOTA: Se considera neblina a una visibilidad menor a 2 km.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, numDia, diaMayor = 0, contN = 0, contL1 = 0, contL2 = 0;
            float visibilidad, mlLluvia, temperatura, tempMax = 0, tempMin = 0, amplitudTermica;

            for (x = 0; x < 15; x++)
            {

                Console.WriteLine("Ingrese numero de dia a cargar: ");
                numDia = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese temperatura: ");
                temperatura = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese mL de lluvia: ");
                mlLluvia = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Visibilidad en KM: ");
                visibilidad = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    tempMax = temperatura;
                    tempMin = temperatura;
                    diaMayor = numDia;
                }

                if (temperatura > tempMax)
                {
                    tempMax = temperatura;
                    diaMayor = numDia;
                }
                else
                {
                    if (temperatura < tempMin)
                    {
                        tempMin = temperatura;
                    }
                }

                if (visibilidad < 2)
                {
                    contN++;
                }

                if (mlLluvia > 0)
                {
                    contL1++;
                }
                else
                {
                    contL2++;
                }
            }

            amplitudTermica = tempMax - tempMin;

            Console.WriteLine("El dia que registro la temperatura maxima es: " + diaMayor);

            Console.WriteLine("La amplitud termica de todo el periodo es: " + amplitudTermica);

            Console.WriteLine("La cantidad de dias con neblina fueron: " + contN);

            if (contL1 > contL2)
            {
                Console.WriteLine("Fue una quincena lluviosa");
            }
            else
            {
                if (contL1 >= 2)
                {
                    Console.WriteLine("Fue una quincena humeda");
                }
                else
                {
                    Console.WriteLine("Fue una quincena seca");
                }
            }
        }
    }
}
