namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                if ((SumOfDigits(i) % 8 == 0) && IsDigitOdd(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int SumOfDigits(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                int dig = n % 10;
                sum += dig;
                n /= 10;    
            }
            return sum;
        }
        public static bool IsDigitOdd(int n)
        {
            bool odd = false;
            while (n > 0)
            {
                int dig = n % 10;
                if(dig % 2 != 0)
                {
                    odd = true;
                    break;
                }
                n /= 10;
            }
            return odd;
        }
    }
}