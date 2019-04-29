using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //ingresar un  numero, y hacer que se muestre un Rombo a partir de este
            Console.WriteLine("Ingrese cantidad");
            int lexs = Convert.ToInt16(Console.ReadLine());
            int i, j, a;
            int x, y, z;
            for ( i = 0; i < lexs; i++)
            {
                for ( j=i; j <lexs; j++)
                { Console.Write(" ");}
                for (a = 0; a!=i; a++)
                {
                    Console.Write("**");
                }
             Console.WriteLine("*");
            }
            
            for (x = 1; x<= lexs; x++)
            {
                for ( y = 0; y!=x; y++)
                {
                    Console.Write(" ");
                }
                for (z=x; z< lexs; z++)
                {
                  Console.Write("**");

                }
                 Console.WriteLine("*");
                
            }
           
            Console.ReadKey();
        }
    }
}
