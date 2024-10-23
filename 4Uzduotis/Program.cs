using System;

namespace KetvirtaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo amziu: ");
            int amzius = int.Parse(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti");
            } else
            {
                Console.WriteLine("Jus negalite balsuoti");
            }
        }
    }
}