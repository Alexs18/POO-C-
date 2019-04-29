using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear un programa que lea una factura
            //1 lea la cantidad //2 introduce precio //termina lectura cantidad sea cero y da el total
            double t=0;
            Console.WriteLine("DIGITE CANTIDAD DE PRODUCTOS");int p = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {

            Console.WriteLine("DIGITE NUMERO DE VENTAS"); int V = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIGITE EL PRECIO"); double pr = Convert.ToInt32(Console.ReadLine());

            if (V==0)
            {
                Console.WriteLine("EJECUCION FINALIZADA");

            }
            else
            {
                t = V * pr;
                Console.WriteLine("CANTIDAD DE PRODUCTOR ADQUIRIDOS ES  "+ V);
                Console.WriteLine("PRECIO POR CANTIDAD  "+ pr);
                    Console.WriteLine("TOTAL A PAGAR " + t);

                }
            }
            Console.ReadKey();




        }

    }

}
