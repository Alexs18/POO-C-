using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREAR UN PROGRAMA QUE INGRESE UN NUMERO, Y A PARTIR DE ESE NUMERO CREE UN CUADRADO, SOLAMENTE LOS BORDES.
            Console.WriteLine("Ingrese cantidad del cuadrado");int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <c; i++)
            {
                for (int a= 0; a < c; a++) 
                {
                    if (i==0||a==0|| a == c - 1|| i == c - 1) 
                    {
                        Console.Write("*");   } 
                    else
                    {
                        Console.Write(" "); 
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
