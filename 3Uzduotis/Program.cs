using System;

namespace TreciaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Pasirinkite, kuri matematini veiksma norite atlikti (+, -, *, /");
            string c = Console.ReadLine();
            switch (c)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;

                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;

                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;

                case "/":
                    if (b == 0 )
                    {
                        Console.WriteLine("Dalyba is 0 negalima!");
                    } else
                    {
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    }
                    break;

                default:
                    Console.WriteLine("Atliktas aritmetinis veiksmas nera implementuotas arba yra ivestas ne aritmetinis veiksmas.");
                    break;
            }
        }
    }
}