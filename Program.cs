using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //crea un programa que lea un numero entero positivo, y que escriba 3 columnas, la primera cuenta desde 1 hasta el numero escrito contando de 1 en 1
            // la segunda de dos en dos y la tercera de 3 en 3
            Console.WriteLine("INGRESE SU NUMERO"); int lexs = Convert.ToInt32(Console.ReadLine());
            int a = 0, b=0, c=0,d =0;
            do
            {
                b++; c = c + 2; d = d+ 3;
                Console.WriteLine(b + "    " + c + "    " + d + "    ");
                a++;
            } while (a<lexs);
            Console.ReadKey();
        }

    }
}
