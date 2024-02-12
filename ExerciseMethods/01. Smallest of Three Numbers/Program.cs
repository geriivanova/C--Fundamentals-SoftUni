namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());    
            GetSmallest(firstNumber,secondNumber,thirdNumber);
        }

        public static void GetSmallest(int a, int b, int c)
        {
            int minValue = a;
            if(b < minValue)
            {
                minValue = b;
            }
            if(c < minValue)
            {
                minValue = c;
            }
            Console.WriteLine(minValue);
        }
    }
}