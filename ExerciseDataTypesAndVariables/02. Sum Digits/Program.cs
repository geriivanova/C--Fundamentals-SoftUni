namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastDigit = 0;
            

            lastDigit = number % 10;
            sum += lastDigit;
            number = number / 10;

            while (number != 0) 
            {
                lastDigit= number % 10;
                sum += lastDigit;
                number = number / 10;
            }

            Console.WriteLine(sum);
        }
    }
}