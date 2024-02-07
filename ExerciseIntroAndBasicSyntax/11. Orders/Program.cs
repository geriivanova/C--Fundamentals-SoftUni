namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            double price;
            double totalPrice=0;
            for(int i=1; i<=n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                price=(day * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}