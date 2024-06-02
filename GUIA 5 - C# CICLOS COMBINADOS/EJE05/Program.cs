using System;

namespace EJE05
{
    /*5
    Se dispone de una lista de 10 grupos de números enteros separados entre ellos por ceros. Se pide determinar e informar:
    a) El número de grupo con mayor porcentaje de números impares positivos respecto al total de números que forman el grupo. 
    Se informa 1 resultado al final.
    b) Para cada grupo el último número primo y en qué orden apareció en ese grupo, si en un grupo no hubiera 
    números primos informar con un cartel aclaratorio. Se informan 2 resultados por cada grupo.
    c) Informar cuantos grupos están formados por todos números ordenados de mayor a menor. Se informa 1 resultado al final.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contadorTotales = 0, impares = 0, porcentajeImparesPositivos = 0, porcentajeMaximo = 0, grupoPorcentajeMaximo = 0, contadorPrimo = 0, ultimoPrimo = 0, ubicacionPrimo = 0;
            int ordenadoMayor = 0, contadorOrdenados = 0;
            bool porcImparMax = true, ordenadoTotal = true;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                while (numero != 0)
                {
                    //A)
                    contadorTotales++;
                    if (numero > 0)
                    {
                        if (numero % 2 != 0)
                        {
                            impares++;
                        }
                    }

                    //B)
                    for (int x = 1; x <= numero; x++)
                    {
                        if (numero%x == 0)
                        {
                            contadorPrimo++;
                        }
                    }

                    if (contadorPrimo == 2)
                    {
                        ultimoPrimo = numero;
                        ubicacionPrimo = contadorTotales;
                    }

                    //C)
                    if (ordenadoMayor == 0)
                    {
                        ordenadoMayor = numero;
                    }
                   
                    if (numero <= ordenadoMayor)
                    {
                        ordenadoMayor = numero;
                        ordenadoTotal = true;
                    }
                    else
                    {
                        ordenadoTotal = false;
                    }

                    contadorPrimo = 0;  

                    Console.WriteLine();
                    Console.Write("Ingrese un número: ");
                    numero = int.Parse(Console.ReadLine());
                }

                //A)
                porcentajeImparesPositivos = (impares * 100) / contadorTotales;

                if (porcImparMax == true || porcentajeImparesPositivos > porcentajeMaximo)
                {
                    porcentajeMaximo = porcentajeImparesPositivos;
                    grupoPorcentajeMaximo = i + 1;
                    porcImparMax = false;
                }

                //B)
                if (ultimoPrimo != 0)
                {
                    Console.WriteLine("El ultimo primo ingresado: " + ultimoPrimo + " ubicacion dentro del grupo: " + ubicacionPrimo);
                }
                else
                {
                    Console.WriteLine("No se ingresasron primos.");
                }

                //C)
                if (ordenadoTotal)
                {
                    contadorOrdenados++;
                }


                ordenadoTotal = true;
                contadorPrimo = impares = contadorTotales = 0;


            }

            //A)
            Console.WriteLine("El grupo con mayor porcentaje de números impares positivos es: " + grupoPorcentajeMaximo);

            //C)
            if (contadorOrdenados == 0)
            {
                Console.WriteLine("No se ingresador grupos ordenados de mayor a menor");
            }
            else
            {
                Console.WriteLine("Se ingresaron: " + contadorOrdenados + " grupo/s ordenados.");
            }
        }
    }
}
