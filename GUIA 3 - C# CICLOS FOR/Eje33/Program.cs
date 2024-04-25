using System;

namespace Eje33
{
    /*Hacer un programa para ingresar una lista de 13 números. Se pide luego determinar e informar:
    A) La cantidad de ternas de valores positivos consecutivos.
    B) La cantidad de ternas de valores negativos consecutivos y ordenados en forma creciente.

    Ejemplo si la lista fuera: 10, 5, 4, 3, -8, -3, -1, 0, 3, 8, -5, -8, -10 entonces el programa
    detectará una terna de positivos consecutivos (10, 5, 4) y una terna de negativos consecutivos
    ordenados (-8, -3, -1)

    Nota: Si el número ingresado es cero, no se lo considera ni negativo ni positivo.
    Nota: La terna (-5, -8, -10) no es contabilizada ya que no se encuentra ordenada crecientemente.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, cont1 = 0, cont2 = 0, men = 0, terna1 = 0, terna2 = 0;

            for (x = 0; x < 13; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    cont1++;
                    cont2 = 0;
                }
                else
                {
                    if (num < 0)
                    {
                        if (cont2 == 0)
                        {
                            men = num;
                            cont2++;
                            cont1 = 0;
                        }
                        else
                        {
                            if (num > men)
                            {
                                men = num;
                                cont2++;
                                cont1 = 0;
                            }
                            else
                            {
                                cont2 = 0;
                                cont1 = 0;
                            }
                        }
                    }
                    else
                    {
                        cont1 = 0;
                        cont2 = 0;
                    }
                }

                if (cont1 == 3)
                {
                    terna1++;
                    cont1 = 0;
                }
                else
                {
                    if (cont2 == 3)
                    {
                        terna2++;
                        cont2 = 0;
                    }
                }
            }

            Console.WriteLine("Cantidad de Ternas Positivos consecutuvos: " + terna1);

            Console.WriteLine("Cantidad de Ternas Negativos consecutuvos ordenados: " + terna2);
        }
    }
}
