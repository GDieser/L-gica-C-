using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. 
            //Luego mostrar cuántos números tiene cada lista.

            int n1, lista = 1;

            //Console.WriteLine("Ingrese la lista numero: "+lista);
            Console.WriteLine("Lista numero: "+lista);

            Console.WriteLine("Ingrese un numero positivo para empezar la lista: ");
            n1 = int.Parse(Console.ReadLine());

            while (n1 >= 0){
                int acuLista = 0;

                while (n1 != 0){

                    acuLista++;
                    Console.WriteLine("Ingrese un numero o 0 para terminar: ");
                    n1 = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine("La lista numero: "+lista+" tiene: "+ acuLista +" numeros");
                lista++;

                Console.WriteLine("Ingrese un numero positivo para empezar la lista o negativo para terminar: ");
                n1 = int.Parse(Console.ReadLine());
            }
            //lista++;
        }
    }
}
