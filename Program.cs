using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
            //CREE UN PROGRAMA QUE RECIBA COMO PARAMETRO UN NUMERO ENTERO
            // Y A PARTIR DE EL CREE UNA PIRAMIDE
        {
            Console.WriteLine("Ingrese cantidad");
            int lexs = Convert.ToInt16(Console.ReadLine());
            int i, j, a;
           
            for (i = 0; i < lexs; i++)
            {
                for (j = i; j < lexs; j++)
                { Console.Write(" "); }
                for (a = 0; a != i; a++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
