using System;

namespace eje20
{
    /*Hacer un programa en el que se ingrese la edad y altura de 5 personas. Luego,
    calcular e informar:
    - La cantidad de personas mayores a 30 años que midan más de 1.8
    metros.
    - El promedio de altura de las personas mayores a 30 años.
    - La cantidad de personas con altura entre 1.7 y 1.8 (ambos inclusive)
    - La cantidad de personas cuya edad sea de 20, 30 o 40 años.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad1, edad2, edad3, edad4, edad5, contMasTreinta1 = 0, contMasTreinta2 = 0, contAltura = 0, contEdades = 0;
            float altura1, altura2, altura3, altura4, altura5, promedio = 0, promedioFinal;

            Console.WriteLine("Ingrese la primera edad: ");
            edad1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda edad: ");
            edad2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la tercera edad: ");
            edad3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la cuarta edad: ");
            edad4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la quinta edad: ");
            edad5 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingresa la primera altura: ");
            altura1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la segunda altura: ");
            altura2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la tercera altura: ");
            altura3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la cuarta altura: ");
            altura4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la quinta altura: ");
            altura5 = float.Parse(Console.ReadLine());

            if (edad1 > 30)
            {
                contMasTreinta1++;
                promedio += altura1;
                if (altura1 > 1.8)
                {
                    contMasTreinta2++;
                }
            }
            if (altura1 >= 1.7 && altura1 <= 1.8)
            {
                contAltura++;
            }
            if (altura1 == 20 || altura1 == 30 || altura1 == 40)
            {
                contEdades++;
            }

            if (edad2 > 30)
            {
                contMasTreinta1++;
                promedio += altura2;
                if (altura1 > 1.8)
                {
                    contMasTreinta2++;
                }
            }
            if (altura2 >= 1.7 && altura2 <= 1.8)
            {
                contAltura++;
            }
            if (altura2 == 20 || altura2 == 30 || altura2 == 40)
            {
                contEdades++;
            }

            if (edad3 > 30)
            {
                contMasTreinta1++;
                promedio += altura3;
                if (altura3 > 1.8)
                {
                    contMasTreinta2++;
                }
            }
            if (altura3 >= 1.7 && altura3 <= 1.8)
            {
                contAltura++;
            }
            if (edad3 == 20 || edad3 == 30 || edad3 == 40)
            {
                contEdades++;
            }

            if (edad4 > 30)
            {
                contMasTreinta1++;
                promedio += altura4;
                if (altura4 > 1.8)
                {
                    contMasTreinta2++;
                }
            }
            if (altura4 >= 1.7 && altura4 <= 1.8)
            {
                contAltura++;
            }
            if (edad4 == 20 || edad4 == 30 || edad4 == 40)
            {
                contEdades++;
            }

            if (edad5 > 30)
            {
                contMasTreinta1++;
                promedio += altura5;
                if (altura5 > 1.8)
                {
                    contMasTreinta2++;
                }
            }
            if (altura5 >= 1.7 && altura5 <= 1.8)
            {
                contAltura++;
            }
            if (edad5 == 20 || edad5 == 30 || edad5 == 40)
            {
                contEdades++;
            }

            promedioFinal = promedio / contMasTreinta1;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|Cant personas +30 y 1.8m            : " + contMasTreinta2);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|Promedio alturas edad +30           : " + promedioFinal);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|Cant. personas altura de 1.7 a 1.8  : " + contAltura);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|Cant. personas edades 20/30/40      : " + contEdades);
            Console.WriteLine("------------------------------------------");

            Console.ReadKey();
        }
    }
}
