namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int lastDigit = 0;
            int newNumber = 0;
            for(int i=1;i<=n;i++)
            {
                lastDigit = i % 10;
                newNumber = i / 10;
                sumOfDigits += lastDigit;
                sumOfDigits += newNumber;
                
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sumOfDigits = 0;
                newNumber = 0;
            }
        }
    }
}