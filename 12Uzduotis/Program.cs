using System;

namespace DvyliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Meniu:\n1. Jautiena - 7 eur\n2. Kiauliena - 6 eur\n3. Vistiena - 3 eur\n4. Aviena - 10 eur\n5. Kalakutiena - 9 eur");
            Console.WriteLine("Pasirinkite meniu patiekalo skaiciu: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Ar norite prideti maisto paruosima (+2€)? (taip/ne)");
            string priedai = Console.ReadLine();
            string patiekalas = "";
            int kaina = 0;

            switch (index)
            {
                case 1:
                    patiekalas = "Jautiena";
                    kaina = 7;
                    break;

                case 2:
                    patiekalas = "Kiauliena";
                    kaina = 6;
                    break;

                case 3:
                    patiekalas = "Vistiena";
                    kaina = 3;
                    break;

                case 4:
                    patiekalas = "Aviena";
                    kaina = 10;
                    break;

                case 5:
                    patiekalas = "Kalakutiena";
                    kaina = 9;
                    break;
            }
            if (priedai == "taip")
            {
                Console.WriteLine($"Galutinis uzsakymas: {patiekalas} (Paruostas) - {kaina + 2} eur");
            } else if (priedai == "ne")
            {
                Console.WriteLine($"Galutinis uzsakymas: {patiekalas} - {kaina} eur");
            }
        }

    }
}