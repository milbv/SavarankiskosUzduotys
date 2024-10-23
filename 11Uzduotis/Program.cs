using System;

namespace VienuoliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite valandini atlyginima (eur): ");
            double valandinis = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite dirbtu valandu skaiciu per savaite:");
            double valandos = double.Parse(Console.ReadLine());
            double atlyginimas;
            
            if (valandos <= 40)
            {
                atlyginimas = valandinis * valandos;
            } else
            {
                atlyginimas = valandinis * 40 + (valandos - 40) * valandinis * 1.5;
            }
            double pajamuMokestis = atlyginimas * 0.1;
            double socMokestis = atlyginimas * 0.05;
            Console.WriteLine($"Galutinis atlyginimas po mokesciu: {atlyginimas - pajamuMokestis - socMokestis} eurai");
        }
    }
}