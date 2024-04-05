using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
        //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los 
        //siguientes datos:
        
        //- Número de Artículo (1 a 15)
        //- Cantidad Vendida 

        //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        //Se pide determinar e informar:
        //a) El número de artículo que más se vendió en total.
        //b) Los números de artículos que no registraron ventas.
        //c) Cuantas unidades se vendieron del número de artículo 10.

        int[] lista = new int [15];
        int n1, n2, max = 0, listaMax = 0, ventas = 0;

        for (int x = 0; x < 15; x++)
        {
            lista[x] = 0;
        }

        Console.WriteLine("Ingresa el numero de lista del articulo: ");
        n1 = int.Parse(Console.ReadLine());

        while (n1 != 0 && n1 < 15)
        {
            n1--;
            Console.WriteLine("Ingresa la cantidad comprada: ");
            n2 = int.Parse(Console.ReadLine());

            if(lista[n1] == 0){
                lista[n1] = n2;
            }else{
                lista[n1] += n2;
            }
            
            //lista[n1] = n2;

            Console.WriteLine("Ingresa el numero de lista del articulo: ");
            n1 = int.Parse(Console.ReadLine());
        }
        for (int y = 0; y < 15; y++)
        {
            if(lista[y] > max){
                max = lista[y];
                listaMax = y;
            }
        }

        Console.WriteLine("El articulo mas vendido es el: " + (listaMax + 1) +" con un cantidad vendido de: "+ max);
        
        for (int z = 0; z < 15; z++)
        {
            if(lista[z] == 0){
                ventas = z;
                ventas++;
                Console.WriteLine("La lista nro: "+ ventas +" no cuentan con ventas...");
            }
        }

        Console.WriteLine("La lista numero 10 tiene: "+lista[9]+" ventas");

        }
    }
}
