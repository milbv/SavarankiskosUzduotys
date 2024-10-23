using System;

namespace PenktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double skaicius = double.Parse(Console.ReadLine());
            if (skaicius > 0) {
                Console.WriteLine($"Skaiciaus {skaicius} kvadratine saknis yra {Math.Sqrt(skaicius)}");
            } else
            {
                Console.WriteLine("Kvadratines saknies apskaiciuoti negalima");
            }
        }
    }
}