using System;

namespace SestaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double skaicius = double.Parse(Console.ReadLine());
            if (skaicius >= 10 && skaicius <= 100)
            {
                Console.WriteLine($"Skaicius {skaicius} yra tarp 10 ir 100");
            } else
            {
                Console.WriteLine($"Skaicius {skaicius} nera tarp 10 ir 100");
            }
        }
    }
}