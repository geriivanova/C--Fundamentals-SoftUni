namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pound=double.Parse(Console.ReadLine());
            double us = 0;
            us = pound * 1.31;
            Console.WriteLine($"{us:F3}");
        }
    }
}