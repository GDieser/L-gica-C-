using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números que 
            //forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int x, lista = 1, porcentajeMaximo = 0, listaMayor = 0, lista2 = 0;

            for(x = 0; x < 2; x++){

                int n1, conImpares = 0, conPares = 0, conTotales = 0, procentaje = 0, lista1 = 0, n2 = 0;
                
                Console.WriteLine("Ingrese la lista numero: "+lista);
                //lista = int.Parse(Console.ReadLine());
                //lista++;

                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());
                n2 = n1;

                while (n1 != 0){
                    conTotales++;

                    if ( n1 % 2 == 0 )
                    //if(n % 2 != 0)
                        //conImpares++;
                        conPares++;
                    else
                        conImpares++;

                    Console.WriteLine("Ingrese un numero: ");
                    n1 = int.Parse(Console.ReadLine());
                    //conTotales++;

                    if(n1 < n2){
                        n2 = n1;
                        lista1++;
                    }
                }
                if(lista1 == conTotales){
                        lista2++;
                    }
                procentaje = (conImpares*100)/conTotales;
                //Console.WriteLine("Porcentaje: "+procentaje);

                if(procentaje > porcentajeMaximo){
                    listaMayor = lista;
                    porcentajeMaximo = procentaje;
                }
                lista++;
            }
            //Console.WriteLine("Lista1: "+ lista1 + "conTotales: "+conTotales);
            Console.WriteLine("La lista con mayor porcentaje de impares es la: "+ listaMayor +" con un porcentaje del: "+ porcentajeMaximo +"%");
            //Console.WriteLine("Lista: "+ listaMayor);
            if(lista2 > 0){
                Console.WriteLine("Hay: "+ lista2 +" grupos ordenados de mayor a menor");
            }
        }
    }
}
