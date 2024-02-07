namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = 0;
            kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}