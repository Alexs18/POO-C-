using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 7 crear un programa que escriba dos columnas de numeros, en la primera que escriba los numeros del 1 al 100,
            // en la segunda los numeros del 100 al 1
            int a=0,b=0,c=101;
            do
            {
                b++;
                c--;

                a++;
                Console.WriteLine(b + "      " + c);
            } while (a<100);            
            Console.ReadKey();
        }
    }
}
