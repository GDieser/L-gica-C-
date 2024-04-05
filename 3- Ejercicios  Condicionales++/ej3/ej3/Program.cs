using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una importante marca de computadoras permite 
            //elegir cierta configuración del equipo a comprar. 
            //Para ello existe la siguiente escala de precios:

            //               i5 (1)	    i7 (2)	    i9 (3)
            //8 RAM (1)	    USD 800	    USD 900	    USD 1200
            //16 RAM (2)	USD 900	    USD 1000	USD 1400
            //32 RAM (3)	USD 1000	USD 1400	USD 2000
            //Además, el equipo viene con un disco que permite 
            //almacenar 500 GB de información y que se puede ampliar 
            //a 1 TB si así lo desea, lo cual tiene un costo  adicional 
            //de USD 300. Hacer un programa que solicite la opción de 
            //procesador, la opción de memoria  RAM, y si extiende 
            //el disco o no (ingresa 1 para extender o 0 para no extender)
            // y calcule y emita por pantalla el monto de la máquina 
             //seleccionada

            int procesador, memoria, disco;
            float precio = 0;
            float precio1 = 300;

            Console.WriteLine("Ingrese que tipo de procesador desea adquirir: 1: I5, 2:I7, 3:I9 ");
            procesador = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cuanta memoria desea adquirir: 1: 8gb, 2: 16gb, 3: 32gb ");
            memoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Queres agrandar el disco?: Si: 1, No: 0");
            disco = int.Parse(Console.ReadLine());


            if(procesador == 1 && memoria == 1){
                    precio = 800;
                }else if(procesador == 1 && memoria == 2){
                 precio = 900;
                }else if(procesador == 1 && memoria == 3){
                    precio= 1000;
                }else if(procesador == 2 && memoria == 1){
                    precio = 900;
                }else if(procesador == 2 && memoria == 2){
                    precio= 1000;
                }else if(procesador == 2 && memoria == 3){
                    precio = 1400;
                }else if(procesador == 3 && memoria == 1){
                    precio= 1200;
                }else if(procesador == 3 && memoria == 2){
                    precio = 1400;
                }else if(procesador == 3 && memoria == 3){
                    precio= 2000;
            }

            if(disco == 1)
                precio = precio + precio1;

            Console.WriteLine("El valor a abonar es: " + precio);

 
        }
    }
}
