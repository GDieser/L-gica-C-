using System;

namespace ejCorteCon
{
    class Program
    {
        static void Main(string[] args)
        {

            //CORTE DE CONTROL
            //LEGAJO, EDAD, SUELDO, COD. EQUIPO 

            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            //codigo de equipo
            //1 river
            //2 boca
            //3 racing

            Console.WriteLine("Ingrese legajo: ");
            legajo = int.Parse(Console.ReadLines());
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLines());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLines());
            Console.WriteLine("Ingrese el codigo de equipo: ");
            codigoEquipo = int.Parse(Console.ReadLines());

            while (sueldo > 0)
            {
                equipoActual == codigoEquipo;
                while (codigoEquipo == equipoActual)
                {
                    //aca procesamos:
                    
                    Console.WriteLine("Ingrese legajo: ");
                    legajo = int.Parse(Console.ReadLines());
                    Console.WriteLine("Ingrese edad: ");
                    edad = int.Parse(Console.ReadLines());
                    Console.WriteLine("Ingrese el sueldo: ");
                    sueldo = float.Parse(Console.ReadLines());
                    Console.WriteLine("Ingrese el codigo de equipo: ");
                    codigoEquipo = int.Parse(Console.ReadLines());
                    
                    //aca mostramos resultados
                }

            }
            //aca mostramos resultados
        }
    }
}
