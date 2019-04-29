using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int boton;
            do
            {
                Console.WriteLine("  ");
            Console.WriteLine("    BIENVENIDO \n" +
                       "AL MENU DE OPCCIONES\n" +
                "\n 1.- Salir"  +
                "\n 2- Sumatorio"  +
                "\n 3.-Factorial\n");

                Console.WriteLine("DIGITE SU OPCCION\n");
                boton = Convert.ToInt32(Console.ReadLine());

            switch (boton)
            {
                case 1:
                    Console.WriteLine("USTED A ELEJIDO LA OPCCION SALIR\n  " +
                        "DIGITE CUALQUIER TECLA PARA SALIR");
                    
                    break;

                case 2:
                        Console.WriteLine("USTED A ELEJIDO LA OPCCION SUMATORIO\n");
                        Console.WriteLine("Elija el numero a calcular el sumatorio\n"); int n1 = Convert.ToInt32(Console.ReadLine());
                        int T = 0;
                         for (int i =n1; i!=0; i--)
                         {   T = T + i;  }
                         Console.WriteLine("el sumatorio es\n "+T);
                    break;
                case 3:
                    Console.WriteLine("USTED A ELEIDO LA OPCCION FATORIAL\n");
                        Console.WriteLine("Digite el numero a calcular el factorial\n"); int n = Convert.ToInt32(Console.ReadLine());
                        int T1=1;
                        for (int i=1;i<=n;i++)
                        {
                            T1 = T1 * i;
                        }
                        Console.WriteLine("el factorial es "+ T1);
                    
                    break;
                    
                default:
                    Console.WriteLine("no se a seleccionado una opccion");
                    break;
            }
            } while (boton!=1);
            Console.ReadKey();

           
        }
    }
}
