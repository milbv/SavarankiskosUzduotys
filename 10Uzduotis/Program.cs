using System;

namespace DesimtaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double skaicius = double.Parse(Console.ReadLine());
            if (skaicius % 2 == 0 && skaicius > 0)
            {
                Console.WriteLine("Skaicius yra teigiamas ir lyginis");
            } else if (skaicius > 0)
            {
                Console.WriteLine("Skaicius yra teigiamas, bet ne lyginis");
            } else if (skaicius % 2 == 0)
            {
                Console.WriteLine("Skaicius yra lyginis, bet ne teigiamas");
            } else if (skaicius == 0)
            {
                Console.WriteLine("Skaicius yra 0");
            } else
            {
                Console.WriteLine("Skaicius yra nei lyginis nei teigiamas");
            }
        }
    }
}