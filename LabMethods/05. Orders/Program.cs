namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product=Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PriceOfProducts(product, quantity);
        }

        static void PriceOfProducts(string product, int quantity)
        {
            if (product == "coffee")
            {
                Console.WriteLine($"{ quantity * 1.50:F2}");
            }
            else if(product == "water")
            {
                Console.WriteLine($"{quantity * 1.00:F2}");
            }
            else if(product == "coke")
            {
                Console.WriteLine($"{quantity * 1.40:F2}");
            }
            else if(product== "snacks")
            {
                Console.WriteLine($"{quantity * 2.00:F2}");
            }
        }
    }
}