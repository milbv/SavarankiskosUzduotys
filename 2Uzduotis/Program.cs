using System;

namespace AntraUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double skaicius = double.Parse(Console.ReadLine());
            if (skaicius % 2 == 0) {
                Console.WriteLine("Skaicius yra lyginis");
            } else
            {
                Console.WriteLine("Skaicius nera lyginis");
            }
        }
    }
}