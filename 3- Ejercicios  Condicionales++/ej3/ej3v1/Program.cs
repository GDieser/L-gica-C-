using System;

namespace ej3v1
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

            if(procesador == 1){
                if(memoria == 1)
                    precio = 800;
                else if(memoria == 2)
                    precio = 900;
                else
                    precio = 1000;
            }else if(procesador == 2){
                if(memoria == 1)
                    precio = 900;
                else if(memoria == 2)
                    precio = 1000;
                else
                    precio = 1400;
            }else if(procesador == 3){
                if(memoria == 1)
                    precio = 1200;
                else if(memoria == 2)
                    precio = 1400;
                else
                    precio = 2000;
            }
            if(disco == 1)
                precio = precio + 300;

            Console.WriteLine("El valor final es: "+ precio);
        }
    }
}
