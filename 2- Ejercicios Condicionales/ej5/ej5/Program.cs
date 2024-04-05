using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa para ingresar cuatro números 
            //y luego mostrar por pantalla cuáles son mayores a 100.


           // float a,b,c,d, m;

           // Console.WriteLine("Ingrese el 1er numero: ");
           // a = float.Parse(Console.ReadLine());

           // Console.WriteLine("Ingrese el 2do numero: ");
          //  b = float.Parse(Console.ReadLine());

           // Console.WriteLine("Ingrese el 3er numero: ");
          //  c = float.Parse(Console.Readline());
            
           // Console.WriteLine("Ingrese el 4to numero: ");
          //  d = float.Parse(Console.ReadLine());

          //  if(a>b)
           //     m = a;
          //  else
         //       m = b;
         //   if(c>m)
        //        m = c;
        //    if(d>m)
        //        m = d;

        //    Console.WriteLine("El numero mayor es: "+m);

        
            float n1, n2, n3, n4, m;

            Console.WriteLine("Ingrese 1er numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 2do numero: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 3er numero: ");
            n3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 4to numero: ");
            n4 = float.Parse(Console.ReadLine());
            
            if(n1 > n2)
                m = n1;
            else
                m = n2;

            if(n3 > m)
                m = n3;
            
            if(n4 > m)
                m = n4;

            Console.WriteLine("El mayor es: "+m);

        }
    }
}
