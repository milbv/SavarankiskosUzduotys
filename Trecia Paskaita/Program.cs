using System;

namespace pirmaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double skaicius = double.Parse(Console.ReadLine());
            if (skaicius > 0 )
            {
                Console.WriteLine($"{skaicius} skaicius yra teigiamas");
            } else if (skaicius < 0)
            {
                Console.WriteLine($"{skaicius} skaicius nera teigiamas");
            } else
            {
                Console.WriteLine("Skaicius yra 0");
            }
        }
    }
}