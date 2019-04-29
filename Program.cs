using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio 1 crear un programa que pida numeros, vea cual es el mayor de ellos
            Console.WriteLine("INGRESE CANTIDAD DE VALORES A EVALUAR");
            int valor = Convert.ToInt32(Console.ReadLine());
            int mayor = 0;
            int[] Numero;
            Numero = new int [valor];
           

                for (int i = 0; i < valor; i++)
                {
                    Console.WriteLine("Ingrese un valor"); Numero[i] = Convert.ToInt32(Console.ReadLine());

                    if (Numero[i] > mayor)
                    {
                        mayor = Numero[i];
                    }

                }
                Console.WriteLine("EL VALOR MAYOR ES " + mayor);
                Console.ReadKey();
            
           

            
        }
    }
}
