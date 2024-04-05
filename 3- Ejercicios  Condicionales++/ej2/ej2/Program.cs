using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido 
            //realiza descuentos dependiendo de la cantidad de 
            //litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el 
            //descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe 
            //total de la venta y la cantidad de litros vendidos y 
            //calcule y emita el importe con el descuento  aplicado..

            float litros, valor; //descuento;

            Console.WriteLine("Ingrese la cantidad L a comprar: ");
            litros = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor total de la compra: ");
            valor = float.Parse(Console.ReadLine());

        //    if(litros < 100){
        //        Console.WriteLine("El valor a abonar es: "+valor);
        //    }else if(litros > 100 && litros <= 300){
        //        descuento = valor * 0.90f;
        //        Console.WriteLine("El valor a abonar es: "+descuento);

        //    }else if(litros > 300 && litros <= 500){
        //        descuento = valor * 0.85f;
        //        Console.WriteLine("El valor a abonar es: "+descuento);
            
        //    }else if(litros > 500){
        //        descuento = valor * 0.75f;
        //        Console.WriteLine("El valor a abonar es: "+descuento);
        //    }

            if(litros > 500)
                valor *=0.75f;
            
            else if(litros > 300)
                valor *=0.85f;
            
            else if(litros > 100)
                valor *=0.90f;
            
            Console.WriteLine("El valor a abonar es: "+valor);

        }
    }
}
