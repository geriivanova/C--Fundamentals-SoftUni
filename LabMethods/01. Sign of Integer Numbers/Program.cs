namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            SignOfNumber(number);
        }
        static void SignOfNumber(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}