namespace Temperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef temperatuur in van gisteren: ");
            string input1 = Console.ReadLine();

            Console.Write("Geef temperatuur in van vandaag: ");
            string input2 = Console.ReadLine();  

            if (float.TryParse(input1, out float temp1)
                && float.TryParse(input2, out float temp2))
            {
                Console.WriteLine($"Verschil: {Math.Abs(temp1 - temp2 )}");
                Console.WriteLine($"Minimum: {Math.Min(temp1, temp2)}");
                Console.WriteLine($"Maximum: {Math.Max(temp1, temp2)}");
            }
            else
            {
                Console.WriteLine("Geef 2 geldige getallen in! ");
            }



                Console.ReadLine();
        }
    }
}
