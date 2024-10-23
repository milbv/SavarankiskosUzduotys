using System;

namespace AstuntaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Sveiki atvyke i zaidima, jei jusu skaicius sutampa su atsitiktiniu skaiciu, laimesi priza!\nIveskite skaiciu (1-10): ");
            int skaicius = int.Parse(Console.ReadLine());
            if (skaicius == random.Next(1, 11))
            {
                Console.WriteLine("Laimejote priza");
            } else
            {
                Console.WriteLine("Deja nesutapo");
            }
        }
    }
}