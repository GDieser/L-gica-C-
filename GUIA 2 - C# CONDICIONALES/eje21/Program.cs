using System;

namespace eje21
{
    /*Una marroquinería dispone de 45 carteras blancas, 50 carteras negras, 40
    marrones y 49 grises. Se pide hacer un programa donde se ingresen tres
    ventas. Cada venta está compuesta por:
    - Cantidad de carteras
    - Tipo de cartera (1 - Blanco, 2 - Negro, 3- Marrón, 4 - Gris)
    Calcular e informar:
    - Cantidad total de carteras vendidas en total.
    - Cuántas carteras quedaron de cada tipo.
    - Los colores de carteras que no se vendieron.
    NOTA: Ninguna venta superará las 10 carteras.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantCartera1, cantCartera2, cantCartera3, cantTotal;
            int blanco = 45, negro = 50, marron = 40, gris = 49;
            char tipoCartera1, tipoCartera2, tipoCartera3;


            Console.WriteLine("---------------");
            Console.WriteLine("| 1 - BLANCO  |");
            Console.WriteLine("---------------");
            Console.WriteLine("| 2 - NEGRO   |");
            Console.WriteLine("---------------");
            Console.WriteLine("| 3 - MARRON  |");
            Console.WriteLine("---------------");
            Console.WriteLine("| 4 - GRIS    |");
            Console.WriteLine("---------------");

            Console.WriteLine("Ingrese tipo de cartera: ");
            tipoCartera1 = char.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            cantCartera1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tipo de cartera: ");
            tipoCartera2 = char.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            cantCartera2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tipo de cartera: ");
            tipoCartera3 = char.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            cantCartera3 = int.Parse(Console.ReadLine());


            if (cantCartera1 > 10)
            {
                Console.WriteLine("Cant. no permitida...");
                cantCartera1 = 0;
            }
            else
            {
                switch (tipoCartera1)
                {
                    case '1':
                        blanco -= cantCartera1;
                        break;
                    case '2':
                        negro -= cantCartera1;
                        break;
                    case '3':
                        marron -= cantCartera1;
                        break;
                    case '4':
                        gris -= cantCartera1;
                        break;
                }
            }

            if (cantCartera2 > 10)
            {
                Console.WriteLine("Cant. no permitida...");
                cantCartera2 = 0;
            }
            else
            {
                switch (tipoCartera2)
                {
                    case '1':
                        blanco = blanco - cantCartera2;
                        break;
                    case '2':
                        negro -= cantCartera2;
                        break;
                    case '3':
                        marron -= cantCartera2;
                        break;
                    case '4':
                        gris -= cantCartera2;
                        break;
                }
            }

            if (cantCartera3 > 10)
            {
                Console.WriteLine("Cant. no permitida...");
                cantCartera3 = 0;
            }
            else
            {
                switch (tipoCartera3)
                {
                    case '1':
                        blanco = blanco - cantCartera3;
                        break;
                    case '2':
                        negro -= cantCartera3;
                        break;
                    case '3':
                        marron -= cantCartera3;
                        break;
                    case '4':
                        gris -= cantCartera3;
                        break;
                }
            }

            if (blanco == 45)
            {
                Console.WriteLine("Cartes Blancas, no realizó ventas.");
            }
            if (negro == 45)
            {
                Console.WriteLine("Cartes Negro, no realizó ventas.");
            }
            if (marron == 45)
            {
                Console.WriteLine("Cartes Marron, no realizó ventas.");
            }
            if (gris == 45)
            {
                Console.WriteLine("Cartes Gris, no realizó ventas.");
            }

            cantTotal = cantCartera1 + cantCartera2 + cantCartera3;

            Console.WriteLine("Se vendieron en total: " + cantTotal);

            Console.WriteLine("---------------------");
            Console.WriteLine("| STOCK BLANCO : |" + blanco);
            Console.WriteLine("---------------------");
            Console.WriteLine("| STOCK NEGRO  : |" + negro);
            Console.WriteLine("---------------------");
            Console.WriteLine("| STOCK MARRON :  |" + marron);
            Console.WriteLine("---------------------");
            Console.WriteLine("| STOCK GRIS   : |" + gris);
            Console.WriteLine("---------------------");

            Console.ReadKey();
        }
    }
}
