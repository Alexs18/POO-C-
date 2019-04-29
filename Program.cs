using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4 crear un programa para calcular el salario mensual de unos empleados a los que" +
                "se les paga 15 dolares por hora, si estas no superan las 35, cada hora por encima de 35 se considera extra " +
                "y se paga a 22 dolares, el programa pide las horas del trabajador, y devuelve el salario que se debe pagar");
            Console.WriteLine("DIGITE SUS HORAS TRABAJADAS"); int horas = Convert.ToInt32(Console.ReadLine());
            double total=0,horast=0,extra=0, total1=0,total2;
            if (horas<=35)
            {
                total = horas * 15;
                Console.WriteLine("SU TOTAL A PAGAR ES DE :" + total);
            }
            else
            {
                horast = horas - 35;
                extra = horast * 22;
                total1 = horas - horast;
                total2 = total1 * 15;
                total = extra + total2;
                Console.WriteLine("SU TOTAL A PAGAR ES:" + total);
                    
            }
            Console.ReadKey();

        }
    }
}
