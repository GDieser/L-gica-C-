using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
        //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
        //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido 
        //reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:

        //CADENA FUENTE: “La mar estaba serena"
        //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //CADENA RESULTADO: “Li mir estibi sereni"

        char[] frase = new char[30];
        //char[] letra1 = new char[1];
        //char[] letra2 = new char[1];

        char letra, letra1, letra2;
        int indice = 0;

        Console.WriteLine("Ingrese la frase... (termine con punto)");
        letra = char.Parse(Console.ReadLine());

            while(letra != '.' && indice < 30){

                frase[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            frase[indice] = '\0';
            indice = 0;

            Console.WriteLine("Ingrese la primera letra: ");
            letra1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda letra: ");
            letra2 = char.Parse(Console.ReadLine());

            indice = 0;

            while (frase[indice] != '\0')
            {
                if(frase[indice] == letra1){
                    frase[indice] = letra2;
                }
                indice++;
            }
            indice = 0;
            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;  
            }
        }
    }
}
