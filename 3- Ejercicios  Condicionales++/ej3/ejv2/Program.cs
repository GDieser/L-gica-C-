using System;

namespace ejv2
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, memoria, disco;
            float precio = 0;
            //float precio1 = 300;

            Console.WriteLine("Ingrese que tipo de procesador desea adquirir: 1: I5, 2:I7, 3:I9 ");
            procesador = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cuanta memoria desea adquirir: 1: 8gb, 2: 16gb, 3: 32gb ");
            memoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Queres agrandar el disco?: Si: 1, No: 0");
            disco = int.Parse(Console.ReadLine());

            switch(procesador){
                case 1:
                    switch (memoria)
                    {
                    case 1:
                        precio = 800;
                        break;
                    case 2:
                        precio = 900;
                        break;
                    case 3:
                        precio = 1000;
                        break;
                    }
                    break;
                case 2:
                    switch (memoria)
                    {
                    case 1:
                        precio = 900;
                        break;
                    case 2:
                        precio = 1000;
                        break;
                    case 3:
                        precio = 1400;
                        break;
                    }
                    break;
                default:
                    switch (memoria)
                    {
                    case 1:
                        precio = 1200;
                        break;
                    case 2:
                        precio = 1400;
                        break;
                    case 3:
                        precio = 2000;
                        break;
                    }
                    break;
                
            }
            if(disco == 1)
                precio = precio + 300;

            Console.WriteLine("El valor final es: "+ precio);
            
        }
    }
}
