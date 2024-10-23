using System;

namespace SeptintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"{a} yra didesnis uz {b}");
            } else if (b > a)
            {
                Console.WriteLine($"{b} yra didesnis uz {a}");
            } else
            {
                Console.WriteLine($"{a} ir {b} yra lygus");
            }
        }
    }
}