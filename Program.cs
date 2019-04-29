using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear programa que escriba la tabla de multiplicar del 1 al 15");
            int a= 0, b = 1, c = 0, t = 0;// las variable estan definidas de la siguiente manera
            // a= contador b=valor de la tabla // c= valor por el cual se multiplicara// y t el resultado
            do
            {
                c++;
                t = b * c;
                Console.WriteLine(b+"X"+c+"="+t);
                a++;

            } while (a<15);
            Console.ReadKey();
        }
    }
}
