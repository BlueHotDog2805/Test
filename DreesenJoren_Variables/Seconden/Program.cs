using System.Dynamic;

namespace Seconden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een aantal seconden in: ");
            string input = Console.ReadLine();
            int Tryparse(input, out int seconds);
          

            int uren = seconds / 3600;
            int minuten = {seconds % 3600} / 60;
            int seconden = seconds % 60;
            
            Console.WriteLine($"H:{uren} M:{minuten} S:{seconden}");

            Console.ReadKey();
        }
    }
}
