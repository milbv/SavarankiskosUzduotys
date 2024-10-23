using System;

namespace DevintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma pazymi");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra pazymi");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite trecia pazymi");
            int c = int.Parse(Console.ReadLine());
            double vidurkis = (double)(a + b + c) / 3;
            if (vidurkis >= 5)
            {
                Console.WriteLine("Patenkinamas");
            } else
            {
                Console.WriteLine("Nepatenkinamas");
            }
        }
    }
}