using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una casa de video juegos otorga un descuento 
            //dependiendo del importe de la compra realizada según 
            //los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, 
            //aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y 
            //luego muestre por pantalla el importe final con el 
            //descuento que corresponda.

            float n1, desc;

            Console.WriteLine("Ingrese el importe a pagar: ");
            
            n1 = float.Parse(Console.ReadLine());

            if(n1 < 1000){
                
                Console.WriteLine("No posee descuentos, valor a pagar: " +n1+"$");

            }else if(n1 < 5000){
                
                desc = n1 - (0.10f * n1);

                Console.WriteLine("Importe de venta: "+n1+" el valor a abonar es: " +desc+"$");
            }else{

                desc = n1 - (0.18f * n1);

                Console.WriteLine("Importe de venta: "+n1+" el valor a abonar es: " +desc+"$");
            }

            Console.WriteLine("Fin bebote");
        }
    }
}
