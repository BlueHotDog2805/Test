namespace ConverterenOefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 12.3456;
            Console.WriteLine($"Price: {price.ToString("F2")}"); // Price: 12,35
                                                                 // of
            Console.WriteLine($"Price: {price:F2}");             // Price: 12,35
            DateTime today = DateTime.Now;
            Console.WriteLine($"Today is: {today:dd/MM/yyyy}"); // Today is: 20/05/2025

            Console.ReadKey();
        }
    }
}
