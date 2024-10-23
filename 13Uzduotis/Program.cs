using System;

namespace TryliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite automobilio tipa:\n1. Sedanas - pradine kaina 100 eur\n2. SUV - pradine kaina 150 eur\n3. Mikroautobusas - pradine kaina 120 eur");
            int index = int.Parse(Console.ReadLine());  
            int kaina = 0;
            switch (index)
            {
                case 1:
                    kaina += 100;
                    break;
                case 2:
                    kaina += 150;
                    break;

                case 3:
                    kaina += 120;
                    break;
            }
            Console.WriteLine("Ar norite apsaugos nuo vagystes? (+50 eur) (taip/ne)");
            string vagystes = Console.ReadLine();
            Console.WriteLine("Ar norite apsaugos nuo stichiju? (+30 eur) (taip/ne)");
            string stichijos = Console.ReadLine();

            if (vagystes == "taip"  && stichijos == "taip")
            {
                kaina += 80;
            }  else if (vagystes == "taip") {
                kaina += 50;
            }  else if (stichijos == "taip") {
                kaina += 30;
            }
            Console.WriteLine($"Galutine draudimo kaina: {kaina} eur");
        }
    }
}