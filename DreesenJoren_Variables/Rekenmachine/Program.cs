namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("geef een geheel getal:");
            string input2 = Console.ReadLine();

            if (!int.TryParse(input1, out int Number1) || !int.TryParse(input2, out int Number2))
            {
                Console.WriteLine("Geef enkel gehele getallen in...");
                Console.ReadKey();
                return;
            }

            Console.Write("Welke bewerking: ");
            string bewerking = Console.ReadLine();

            switch (bewerking)
            {
                case "+":
                    Console.Write($"Het resultaat is {Number1 + Number2}");
                    break;
                case "-":
                    Console.Write($"Het resultaat is {Number1 - Number2 }");
                    break;
                case "*":
                    Console.Write($"Het resultaat is {Number1 * Number2}");
                   break;
                case "/":
                    Console.Write($"Het resultaat is {Number1 / Number2}");
                    break;
                default:
                    Console.WriteLine("Dit is geen geldige bewerking!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
