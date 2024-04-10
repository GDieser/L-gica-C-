using System;

namespace eje1
{

    /*Hacer un programa para ingresar por teclado un número y luego emitir por
    pantalla un cartel aclaratorio indicando si el mismo es positivo, negativo o cero.
    Importante: Verifique que el programa emita UN SOLO CARTEL.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0){
                
                Console.WriteLine("El numero ingresado es positivo: " + num);
            }
            else if (num < 0){
                
                Console.WriteLine("El numero ingresado es negativo: " + num);
                
            }else{
                
                Console.WriteLine("El numero ingresado es cero: " + num);
                
                
            }

            Console.ReadKey();
        }
    }
}
