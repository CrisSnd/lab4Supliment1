using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Se citesc doua numere de la tastatura. Scrieti un program care va calcula cel mai mare divizor comun al numerelor.*/

            Console.WriteLine("Introduceti 2 numere: ");

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int cmmdc = 1;

            for(int i = 1; i <= Math.Min(a,b); i++) 
            {
                if (a%i == 0 && b%i == 0) 
                {
                    cmmdc=i;    
                }

            }

            Console.WriteLine("Cel mai mare divizor comun este:" + " " +cmmdc);
        }


     }
 }

